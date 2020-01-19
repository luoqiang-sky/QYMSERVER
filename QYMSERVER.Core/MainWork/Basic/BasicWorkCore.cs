using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Hangfire;
using Abp.Modules;
using Castle.Core.Logging;
using Hangfire;
using QYMSERVER.Entities.BOM;
using QYMSERVER.Entities.Equipment;
using QYMSERVER.Entities.Product;
using QYMSERVER.Entities.SystemConfig;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.MainWork.Basic
{
    [DependsOn(typeof(AbpHangfireModule))]
    public class BasicWorkCore:IBasicWorkCore
    {
        private readonly IRepository<PRODTABLE> _PRODTABLERepository;
        private readonly IRepository<PRODROUTE> _PRODROUTERepository;
        private readonly IRepository<SYS_CONFIG> _SYS_CONFIGRepository;
        private readonly IRepository<PRODJOURNALBOM> _PRODJOURNALBOMRepository;
        private readonly IRepository<Machines> _MachinesRepository;
      
        public static List<PRODTABLE> ProductTables = new List<PRODTABLE>();
        public ILogger Logger { get; set; }
        public BasicWorkCore(IRepository<PRODTABLE> PRODTABLERepository, IRepository<PRODROUTE> PRODROUTERepository, 
            IRepository<SYS_CONFIG> SYS_CONFIGRepository, IRepository<PRODJOURNALBOM> PRODJOURNALBOMRepository, IRepository<Machines> MachinesRepository)
        {
            _PRODTABLERepository = PRODTABLERepository;
            _PRODROUTERepository = PRODROUTERepository;
            _SYS_CONFIGRepository = SYS_CONFIGRepository;
            _PRODJOURNALBOMRepository=PRODJOURNALBOMRepository;
            _MachinesRepository = MachinesRepository;
            Logger = NullLogger.Instance;
            ProductTableMonitoring();
        }
        public void ProductTableMonitoring()
        {
            RecurringJob.AddOrUpdate("MainProductTableMonitoring", () => ProductTableMonitor(), Cron.MinuteInterval(1), TimeZoneInfo.Utc);
            //RecurringJob.RemoveIfExists("ProductTableMonitoring");

        }
        /// <summary>
        /// 监控LocalDB中的生产订单，如有符合生产就下发，没有就继续监控
        /// </summary>
        public void ProductTableMonitor()
        {
            ProductTables = _PRODTABLERepository.GetAllList().Where(p => p.PRODSTATUS >= 4).OrderBy(p => p.PRODPRIO).ToList();
            var auto = _SYS_CONFIGRepository.FirstOrDefault(p => p.KEY == "AUTOSYSTEM");//判断全局是否是自动模式
            if (auto == null)
            {
                Logger.Error("配置文件中缺少AUTOSYSTEM选项！");
                
                return;
            }
            else
            {
                if (auto.VALUE == "TRUE")//自动分配生产订单
                {
                    if (ProductTables[0].ISSTARTED != 1 && ProductTables[0].IWS_WRKCTRID != null && ProductTables[0].IWS_ISSUSPEND != 1)//1、订单未开始 2、订单目标工作中心空闲（主要是光刻机的状态了）3、不是在暂停状态下
                    {
                            RecurringJob.AddOrUpdate(ProductTables[0].PRODID + "_ProductTableMonitoring", () => SingleProductTableMonitoring(ProductTables[0].PRODID), Cron.MinuteInterval(1), TimeZoneInfo.Utc);

                            ProductTables[0].ISSTARTED = 1;
                            _PRODTABLERepository.Update(ProductTables[0]);//生产订单标记已经开始加工

                            Logger.Info("订单" + ProductTables[0].PRODID + "订单已经下发，即将开始生产 ");
                    }
                }
            }
        }
        /// <summary>
        /// 单个生产订单监控（包括订单流程状态和所有的工序订单的状态监控,使用RUTENU和RUTENUMNEXT进行工序跟踪）
        /// </summary>
        /// <param name="prodid"></param>
        public void SingleProductTableMonitoring(string prodid)
        {
            //获取生产订单下面的所有工序订单，首次下发时，查找首工序（暂定为光刻2020），下发时再附带工序订单的生产参数；非首次
            //生成一个hangfire服务，确保所有工序订单都执行完毕，之后关闭此hangfire服务
            //hangfire服务在处理的过程中，应该可以试试接收新增的订单。即每次执行前都应该再次检查上一道工序中是否允许流入下一个工序的标志。
            PRODTABLE THISPRODIDTABLE = ProductTables.First(p => p.PRODID == prodid) ;// _PRODTABLERepository.FirstOrDefault(x => x.PRODID == prodid);
            if (THISPRODIDTABLE.IWS_ISSUSPEND != 1)//生产订单暂停功能 =>开始执行工序订单发送程序=>直接在此后台任务重调度
            {
                if (THISPRODIDTABLE.ISSTARTED == 0)//生产订单没有开始的情况下，第一次进入工序流程
                {
                    var firstroute = _PRODROUTERepository.FirstOrDefault(p => (p.PRODID == prodid && p.PRODID== "2020"));//get 生产订单的所有工序，并且在动态接收用户新增工序。
                    if (firstroute == null)
                    {
                        Logger.Error("订单" + THISPRODIDTABLE.PRODID + "缺少首道工序！");
                        return;
                    }
                    if (firstroute.ISSTARTED == 0)
                    {
                        RecurringJob.AddOrUpdate(THISPRODIDTABLE.PRODID + "_RouteRunAndTracking_" + firstroute.OPRID, () => RouteRunAndTracking(firstroute,null), Cron.MinuteInterval(1), TimeZoneInfo.Utc);
                        THISPRODIDTABLE.ISSTARTED = 1;
                        _PRODTABLERepository.Update(THISPRODIDTABLE);//标记该生产订单已经开始生产了
                    }
                    else
                    {
                        Logger.Error("订单" + THISPRODIDTABLE.PRODID + "已经开始！但不符合指定逻辑 ！");
                    }
                }
            }
            if (THISPRODIDTABLE.ISSTARTED == 2)//此生产订单生产完成
            {
                //报工
                FeedBackToAX(THISPRODIDTABLE.PRODID);
                //结束此订单任务
                RecurringJob.RemoveIfExists(THISPRODIDTABLE.PRODID + "_ProductTableMonitoring");
            }
        }
        /// <summary>
        /// 工序订单运行和监控     由OPRNUM=>OPRNUMNEXT 单个路线反馈的数据
        /// </summary>
        /// <param name="firstroute">当前要执行的工序</param>
        /// <param name="firstroute">上一道工序</param>
        public void RouteRunAndTracking(PRODROUTE CURRENTROUTE,PRODROUTE LASTROUTE)
        {
            switch (CURRENTROUTE.ISSTARTED)
            {
                case 0:
                    if (CURRENTROUTE.ISSTARTED == 0 && _MachinesRepository.FirstOrDefault(p => p.WRKCTRGROUP == CURRENTROUTE.WRKCTRID).STATUS == 0)//工序订单还没开始做，并且目标机器人设备处于空闲状态
                    {
                        var itemid = _PRODJOURNALBOMRepository.FirstOrDefault(p => p.PRODID == CURRENTROUTE.PRODID).IWS_INVENTSERIALID;//获取流程单号
                        var prodtable = _PRODTABLERepository.FirstOrDefault(p => p.PRODID == CURRENTROUTE.PRODID);
                        var chang = prodtable.IWS_SPECIFICATIONS;//获得长宽高
                        var kuan = prodtable.IWS_SPECIFICATIONS2_;
                        var gao = prodtable.IWS_SPECIFICATIONS3_;
                        var from = "";//从哪里搬
                        var to = prodtable.IWS_WRKCTRGRP;//搬到那里去
                        var plant = _MachinesRepository.FirstOrDefault(x => x.WRKCTRGROUP == CURRENTROUTE.WRKCTRID).PLANT;
                        if (LASTROUTE == null)
                        {
                            from = "0";
                        }
                        else
                        {
                            from = LASTROUTE.WRKCTRID;
                        }

                        bool result = SendToRobot(plant, itemid, from, to, chang, kuan, gao, true); //给机器人发送工序订单
                        if (result == true)
                        {
                            //更新设备状态
                            var machine = _MachinesRepository.FirstOrDefault(p => p.WRKCTRGROUP == CURRENTROUTE.WRKCTRID);//此处的工作中心和工作组的关系表还没有确定，确定之后统一使用工作中心组做比较。
                            machine.STATUS = 1;
                            _MachinesRepository.Update(machine);

                            //更新工序订单状态
                            CURRENTROUTE.ISSTARTED = 1;
                            _PRODROUTERepository.Update(CURRENTROUTE);
                        }
                        else
                        {
                            bool result1 = SendToRobot(plant, itemid, from, to, chang, kuan, gao, true);//再次流程写入，不到万不得已，不使用HangFire
                            if (result1 == true)
                            {
                                var machine = _MachinesRepository.FirstOrDefault(p => p.WRKCTRGROUP == CURRENTROUTE.WRKCTRID);//此处的工作中心和工作组的关系表还没有确定，确定之后统一使用工作中心组做比较。
                                machine.STATUS = 1;
                                _MachinesRepository.Update(machine);//更新设备状态

                                CURRENTROUTE.ISSTARTED = 1;
                                _PRODROUTERepository.Update(CURRENTROUTE);//更新订单状态
                            }
                            else
                            {
                                RecurringJob.AddOrUpdate(itemid + "_SendToRoboting", () => ReSendToRobot(CURRENTROUTE, plant, itemid, from, to, chang, kuan, gao, true), Cron.MinuteInterval(5), TimeZoneInfo.Utc);
                            }
                        }

                    }
                    break;
                case 1:
                    //本工序正在生产，其他工序处理不用等待，直接跳过
                    break;
                case 2://本工序已经做完，则开始检索下一道工序，进一步处理。（工序完整状态要结合客户端，用户手动情况以及自动检测情况之后，再进行更新）
                    var currentproducttable = _PRODTABLERepository.FirstOrDefault(p => p.PRODID == CURRENTROUTE.PRODID);//为什么不用ProductTables？ 其他操作可能导致订单提前结束
                    if (currentproducttable == null)
                    {
                        Logger.Error($"工程中不存在生产订单{ CURRENTROUTE.PRODID },请核实！");
                        break;
                    }
                    if (currentproducttable.IWS_ISSUSPEND == 1)//生产订单被暂停，工序不能继续进行分配
                    {
                        Logger.Error($"订单{CURRENTROUTE.PRODID}暂停，暂停在工序{CURRENTROUTE.PRODID}，重启订单后将继续。");
                        break;
                    }               
                    if (CURRENTROUTE.OPRID == "8020")//打包入库工序完成（最后一道工序，特殊OPRNUM）
                    {
                        PRODTABLE THISPRODIDTABLE = _PRODTABLERepository.FirstOrDefault(p => p.PRODID == CURRENTROUTE.PRODID);
                        THISPRODIDTABLE.ISSTARTED = 2;
                        _PRODTABLERepository.Update(THISPRODIDTABLE);

                        RecurringJob.RemoveIfExists(CURRENTROUTE.PRODID + "_RouteRunAndTracking_" + CURRENTROUTE.OPRID);

                    }
                    else //不是最后一道工序
                    {
                        LASTROUTE = CURRENTROUTE;
                        CURRENTROUTE = _PRODROUTERepository.FirstOrDefault(x => x.OPRNUM == LASTROUTE.OPRNUMNEXT && x.PRODID == LASTROUTE.PRODID);
                        //工序订单替换成下一道工序,
                        //PS：插单的情况如何处理？
                        //客户端操作CURRENTROUTE.ISSTARTED == 2需要插单的时候，将CurrentRoute的nextnum修改为新插入的订单的num，新插入的route的nextnum为currentroute的oldnum
                        //这样的话，此处的CURRENTROUTE已经是插入的新工序订单了。                                                                                                                                

                        RecurringJob.AddOrUpdate(CURRENTROUTE.PRODID + "_RouteRunAndTracking_" + CURRENTROUTE.OPRID, () => RouteRunAndTracking(CURRENTROUTE, LASTROUTE), Cron.MinuteInterval(1), TimeZoneInfo.Utc);
                        RecurringJob.RemoveIfExists(LASTROUTE.PRODID + "_RouteRunAndTracking_" + LASTROUTE.OPRID);
                    }
                 break;

                default:

                    break;
            }
        }
        public void ReSendToRobot(PRODROUTE CURRENTROUTE,int robot, string IWS_INVENTSERIALID,string FROM, string WRKCTRGROUPID, decimal? LONG, decimal? WIDTH, decimal? HEIGH, bool Start)
        {
            var result = SendToRobot( robot,  IWS_INVENTSERIALID, FROM, WRKCTRGROUPID,   LONG,  WIDTH,  HEIGH,  Start);
            if (result)
            {
                //更新设备状态
                var machine = _MachinesRepository.FirstOrDefault(p => p.WRKCTRGROUP == CURRENTROUTE.WRKCTRID);//此处的工作中心和工作组的关系表还没有确定，确定之后统一使用工作中心组做比较。
                machine.STATUS = 1;
                _MachinesRepository.Update(machine);

                //更新订单状态
                CURRENTROUTE.ISSTARTED = 1;
                _PRODROUTERepository.Update(CURRENTROUTE);

                RecurringJob.RemoveIfExists(IWS_INVENTSERIALID + "_SendToRoboting");
            }
        }
        /// <summary>
        /// 给机器人发送工序信息
        /// </summary>
        /// <param name="robot">机器人编号 1-3 A B C </param>
        /// <param name="IWS_INVENTSERIALID">流程单号</param>
        /// <param name="FROM">目的地（工作中心组）</param>
        /// <param name="TO">目的地（工作中心组）</param>
        /// <param name="LONG">板材长度</param>
        /// <param name="WIDTH">板材宽度</param>
        /// <param name="HEIGH">板材厚度</param>
        /// <param name="Start">机器人开始</param>
        public bool SendToRobot(int robot,string IWS_INVENTSERIALID, string FROM, string TO,decimal? LONG, decimal? WIDTH, decimal? HEIGH,bool Start)
        {
            bool result = false;
            List<string> nodeIds = new List<string>();
            nodeIds.Add($"ns=2;s=Devices/分厂一/{robot}/ModbusTcp客户端/温度");
            nodeIds.Add($"ns=2;s=Devices/分厂一/{robot}/ModbusTcp客户端/风俗");
            nodeIds.Add($"ns=2;s=Devices/分厂一/{robot}/ModbusTcp客户端/转速");
            nodeIds.Add($"ns=2;s=Devices/分厂一/{robot}/ModbusTcp客户端/机器人关节");
            nodeIds.Add($"ns=2;s=Devices/分厂一/{robot}/ModbusTcp客户端/cvsdf");
            nodeIds.Add($"ns=2;s=Devices/分厂一/{robot}/ModbusTcp客户端/条码");
            nodeIds.Add($"ns=2;s=Devices/分厂一/{robot}/ModbusTcp客户端/开关量");
            List<string> values = new List<string>();
            values.Add(IWS_INVENTSERIALID);
            values.Add(FROM);
            values.Add(TO);
            values.Add(LONG.ToString());
            values.Add(WIDTH.ToString());
            values.Add(HEIGH.ToString());
            values.Add(Start.ToString());
            //do sent to plc work
            switch (robot)
            {
                case 1:
                    result= QYMSERVERCoreModule.A_OpcUaClient.WriteNodes(nodeIds.ToArray(), values.ToArray());
                    break;
                case 2:
                    result = QYMSERVERCoreModule.B_OpcUaClient.WriteNodes(nodeIds.ToArray(), values.ToArray());
                    break;
                case 3:
                    result = QYMSERVERCoreModule.C_OpcUaClient.WriteNodes(nodeIds.ToArray(), values.ToArray());
                    break;
            }
            return result;
        }
        /// <summary>
        /// 报工
        /// </summary>
        /// <param name="prodid"></param>
        public void FeedBackToAX(string prodid)
        {

        }
    }
}
