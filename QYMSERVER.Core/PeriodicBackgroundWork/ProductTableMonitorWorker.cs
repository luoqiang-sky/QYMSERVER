using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Threading.BackgroundWorkers;
using Abp.Threading.Timers;
using QYMSERVER.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.PeriodicBackgroundWork
{
    /// <summary>
    /// 定时去检查AX中PRODTABLE及其他需要的生产订单相关表，有更新就更新本地数据库，并通知客户端
    /// </summary>
    public class ProductTableMonitorWorker : PeriodicBackgroundWorkerBase, ISingletonDependency
    {
        private readonly IRepository<PRODTABLE> _productTableRepository;
        public ProductTableMonitorWorker(AbpTimer timer, IRepository<PRODTABLE> userRepository): base(timer)
        {
            _productTableRepository = userRepository;
            Timer.Period = 1000; //1 seconds (good for tests, but normally will be more)
        }
        [UnitOfWork]
        protected override void DoWork()
        {
            //var temp= _productTableRepository.GetAll().Where(x => x.PRODID == "PD00471918");
            // PRODTABLEDto q= temp.MapTo<PRODTABLEDto>();
            // if (q != null)
            // {
            //Logger.Info("定时去检查AX中PRODTABLE及其他需要的生产订单相关表，有更新就更新本地数据库，并通知客户端");

            // }
        }
    }
}
