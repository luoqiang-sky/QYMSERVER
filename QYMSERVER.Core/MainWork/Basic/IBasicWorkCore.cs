using Abp.Domain.Services;
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
        void AssignAnalyze(string prodid);
    }
}
