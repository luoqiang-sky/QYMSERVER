using Abp.Application.Services;
using QYMSERVER.ClientService.MPS;
using QYMSERVER.Entities.Product;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.ClientService.MPS
{
    /// <summary>
    /// 工序订单的所有功能接口
    /// </summary>
    public interface IRouteWorkAppService: IApplicationService
    {
        /// <summary>
        /// 获取一个生产订单下面的所有工序
        /// </summary>
        /// <param name="prodid">生产订单ID</param>
        /// <param name="routeid">工序ID</param>
        /// <param name="num">工序编号（重复操作的工序由此编号区分）</param>
        /// <returns></returns>
        PRODROUTEDto GetProductRouteByID(string prodid, string routeid, int num);
        /// <summary>
        /// 获取一个生产订单下面的所有工序
        /// </summary>
        /// <param name="prodid"></param>
        /// <returns></returns>
        Task<ObservableCollection<PRODROUTEDto>> GetRoutesByIDAsync(string prodid);
        /// <summary>
        /// 给特定生产订单插入一个工序ID
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task InsertOneProductRoute(PRODROUTEDto input);
        /// <summary>
        /// 删除一个工序 
        /// </summary>
        /// <param name="prodid">生产订单ID</param>
        /// <param name="routeid">工序ID</param>
        /// <param name="num">工序编号（重复操作的工序由此编号区分）</param>
        Task DeleteOneRoute(string prodid, string routeid, int num);
        /// <summary>
        /// 修改工序的某个参数
        /// </summary>
        /// <param name="prodid"></param>
        /// <param name="routeid"></param>
        /// <param name="num"></param>
        /// <param name="WorkCenterValue">value</param>
        Task ModifyOneRoute(string prodid, string routeid, int num, string WorkCenterValue);
        /// <summary>
        /// 计算当前工序可选工作中心
        /// </summary>
        /// <param name="prodid"></param>
        /// <param name="routeid"></param>
        /// <returns></returns>
        Task<List<string>> CalcRouteWorkCenters(string prodid, string routeid);

    }
}
