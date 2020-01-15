using Abp.Domain.Repositories;
using Abp.Hangfire;
using Abp.Modules;
using Castle.Core.Logging;
using Hangfire;
using QYMSERVER.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.BasicWork
{
    /// <summary>
    ///                                     由于Core层不实现数据库仓储，所以讲这部分放到应用层
    /// </summary>
    [DependsOn(typeof(AbpHangfireModule))]
    public class BasicWorkCore
    {
        private readonly IRepository<PRODTABLE> _PRODTABLERepository;
        private readonly IRepository<PRODROUTE> _PRODROUTERepository;
        public ILogger Logger { get; set; }

        public static List<PRODTABLE> ProductTables = new List<PRODTABLE>();
        public BasicWorkCore(IRepository<PRODTABLE> repository, IRepository<PRODROUTE> repository1)
        {
            _PRODTABLERepository = repository;
            _PRODROUTERepository = repository1;
            Logger = NullLogger.Instance;

            //RecurringJob.AddOrUpdate("ProductTableMonitoring", () => ProductTableMonitoring(), Cron.MinuteInterval(1), TimeZoneInfo.Utc);

        }
        /// <summary>
        /// 监控LocalDB中的生产订单，如有符合生产就下发，没有就继续监控
        /// </summary>
        public void ProductTableMonitoring()
        {
            ProductTables = _PRODTABLERepository.GetAllList().Where(p => p.PRODSTATUS >= 4).OrderBy(p => p.PRODPRIO).ToList();
            ProductTables = (List<PRODTABLE>)ProductTables.OrderBy(p => p.PRODPRIO).ThenBy(p => p.PRODPRIO);
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
