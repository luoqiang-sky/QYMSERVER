using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Hangfire;
using Abp.Modules;
using Castle.Core.Logging;
using Hangfire;
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

        public static List<PRODTABLE> ProductTables = new List<PRODTABLE>();
        public ILogger Logger { get; set; }
        public BasicWorkCore(IRepository<PRODTABLE> PRODTABLERepository, IRepository<PRODROUTE> PRODROUTERepository, IRepository<SYS_CONFIG> SYS_CONFIGRepository)
        {
            _PRODTABLERepository = PRODTABLERepository;
            _PRODROUTERepository = PRODROUTERepository;
            _SYS_CONFIGRepository = SYS_CONFIGRepository;
            Logger = NullLogger.Instance;
            ProductTableMonitoring();
        }
        /// <summary>
        /// 监控LocalDB中的生产订单，如有符合生产就下发，没有就继续监控
        /// </summary>
        public void ProductTableMonitor()
        {
            ProductTables = _PRODTABLERepository.GetAllList().Where(p => p.PRODSTATUS >= 4).OrderBy(p => p.PRODPRIO).ToList();
        }
        /// <summary>
        /// 报工
        /// </summary>
        /// <param name="prodid"></param>
        public void FeedBackToAX(string prodid)
        {

        }

        public void ProductTableMonitoring()
        {
            RecurringJob.AddOrUpdate("ProductTableMonitoring", () => ProductTableMonitor(), Cron.MinuteInterval(1), TimeZoneInfo.Utc);
            AssignAnalyze("PD00471938");
            RecurringJob.RemoveIfExists("ProductTableMonitoring");

        }
        /// <summary>
        /// 分解订单并发送订单
        /// </summary>
        /// <param name="prodid"></param>
        public void AssignAnalyze(string prodid)
        {
            //获取生产订单下面的所有工序订单，并且附带工序订单的生产参数
            //生成一个hangfire服务，确保所有工序订单都执行完毕，之后关闭此hangfire服务
            // hangfire服务在处理的过程中，应该可以试试接收新增的订单。即每次执行前都应该再次检查上一道工序中是否允许流入下一个工序的标志。
            //
            //
            var routes = _PRODROUTERepository.GetAllList().Where(p => p.PRODID==prodid).OrderBy(p => p.LEVEL_).ToList();
        }
    }
}
