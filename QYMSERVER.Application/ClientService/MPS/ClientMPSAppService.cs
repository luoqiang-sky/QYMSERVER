using Abp.Application.Services;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Hangfire;
using Abp.Modules;
using Hangfire;
using QYMSERVER.ClientService.MPS.Dto;
using QYMSERVER.Entities.IWS;
using QYMSERVER.Entities.Product;
using QYMSERVER.MainWork.Basic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.ClientService.MPS
{
    [DependsOn(typeof(AbpHangfireModule))]
    public class ClientMPSAppService: QYMSERVERAppServiceBase, IClientMPSAppService
    {
        private readonly IRepository<PRODTABLE> _PRODTABLERepository;
        private readonly IRepository<ROUTEOPRTABLE> _ROUTEOPRTABLERepository; 
        private readonly IRepository<PRODROUTE> _PRODROUTERepository;
        public ClientMPSAppService(IRepository<PRODTABLE> repository, IRepository<ROUTEOPRTABLE> repository1, IRepository<PRODROUTE> repository2, IBasicWorkCore basicWorkCore)
        {
            _PRODTABLERepository = repository;
            _ROUTEOPRTABLERepository = repository1;
            _PRODROUTERepository = repository2;
        }
        #region  仓储方法
        //public ObservableCollection<PRODTABLE> Entities { get; }  给客户端提供数据结构
        ////例子一
        //var query = from person in _personRepository.GetAll()
        //            where person.IsActive
        //            orderby person.Name
        //            select person;
        //var people = query.ToList();

        ////例子二
        //List<Person> personList2 = _personRepository.GetAll().Where(p => p.Name.Contains("H")).OrderBy(p => p.Name).Skip(40).Take(20).ToList();

        #endregion
        /// <summary>
        /// 获取所有订单状态》=4的订单（》=4表示可以生产的状态订单）(由于用户操作的时候数据库查询效率可能存在延迟，这部分查询工作由Core从的BasicWorkCore来处理，这查询直接返回一个现成的数组)
        /// </summary>
        /// <returns></returns>
        public async Task<ObservableCollection<PRODTABLEDto>> GetProductByStatusAsync()
        {
            var temp = _PRODTABLERepository.GetAll().Where(p => p.PRODSTATUS >= 4).OrderBy(p => p.PRODPRIO).ToList().OrderBy(p=>p.PRODPRIO);
            return temp.MapTo<ObservableCollection<PRODTABLEDto>>();

        }
        /// <summary>
        /// 获取指定PRODID的生产订单
        /// </summary>
        /// <param name="prodid"></param>
        /// <returns></returns>
        public PRODTABLEDto GetProductByID(string prodid)
        {
            var temp = _PRODTABLERepository.FirstOrDefault(pro => pro.PRODID == prodid);
            //var temp1 = _PRODTABLERepository.GetAll().Where(product=>product.PRODID ==prodid);
            return temp.MapTo<PRODTABLEDto>();
        }
        /// <summary>
        /// 插入一个生产订单（业务逻辑上是不允许的）
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns> 
        public async Task PostInsertOneProduct(PRODTABLE input)
        {
            await _PRODTABLERepository.InsertAndGetIdAsync(input);
        }
        /// <summary>
        /// 删除一个生产订单
        /// </summary>
        /// <param name="prodid"></param>
        public void DeleteOneProduct(string prodid)
        {
            var temp = _PRODTABLERepository.FirstOrDefault(pro => pro.PRODID == prodid);

            if (temp != null)
            {
                _PRODTABLERepository.Delete(temp);
            }
            RecurringJob.AddOrUpdate("MyCycle", () => Logger.Info("22222222222222222222222222222222222222222222222"), Cron.MinuteInterval(1));//这种写法的日志无法识别
            Logger.Info("RecurringJob.AddOrUpdate(666666666666666666666666)");
        }
        /// <summary>
        /// 获取订单的进度（客户端子页面中展示生产订单当前进度，展示每个工序状态）
        /// </summary>
        /// <returns></returns>
        public async Task<ObservableCollection<ProcessInfoDto>> GetRouteProcessAsync(string prodid)
        {
            var temp = await _PRODROUTERepository.GetAllListAsync(x=>x.PRODID==prodid);
            ObservableCollection<ProcessInfoDto> ProcessInfos = new ObservableCollection<ProcessInfoDto>();
            foreach (var Product in temp)
            {
                var q = _ROUTEOPRTABLERepository.FirstOrDefault(x => x.OPRID == Product.OPRID);
                var a = (q == null)? " NULL" : q.NAME;
                ProcessInfos.Add(new ProcessInfoDto()
                {
                    ProcessName = Product.OPRID + a,
                    WorkCenter = Product.WRKCTRID,
                    LEVEL = Product.LEVEL_,
                    Result = ((Func<ProcessStatus>)(() => {
                        switch (Product.OPRFINISHED)
                        {
                            case 0:
                                return ProcessStatus.等待;
                            case 1:
                                return ProcessStatus.完成;
                            case 2:
                                return ProcessStatus.进行中;
                            case 3:
                                return ProcessStatus.警告;
                            case 4:
                                return ProcessStatus.返工;
                        }
                        return ProcessStatus.等待;
                    }))()
                });
            }
            return ProcessInfos;
        }

    }
}
