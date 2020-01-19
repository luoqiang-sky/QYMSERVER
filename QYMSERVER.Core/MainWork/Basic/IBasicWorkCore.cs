using Abp.Domain.Services;
using QYMSERVER.Entities.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.MainWork.Basic
{
    public interface IBasicWorkCore
    {
        /// <summary>
        /// 监控LocalDB中的生产订单表
        /// </summary>
        void ProductTableMonitoring();
        /// <summary>
        /// 分解订单，并发送给机器人
        /// </summary>
        /// <param name="prodid"></param>
        void SingleProductTableMonitoring(string prodid);
        /// <summary>
        /// 生产订单报工
        /// </summary>
        /// <param name="prodid"></param>
        void FeedBackToAX(string prodid);
        /// <summary>
        /// 监控工序执行 并自动导入下一步工序
        /// </summary>
        /// <param name="FIRSTROUTE"></param>
        void RouteRunAndTracking(PRODROUTE CURRENTROUTE, PRODROUTE LASTROUTE);
    }
}
