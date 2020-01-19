using Abp.Application.Services;
using QYMSERVER.ClientService.MPS.Dto;
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
    /// 一般的MPS任务接口
    /// </summary>
    public interface IClientMPSAppService: IApplicationService
    {
        /// <summary>
        /// 获取一个生产订单
        /// </summary>
        /// <param name="prodid"></param>
        /// <returns></returns>
        PRODTABLEDto GetProductByID(string prodid);
        /// <summary>
        /// 获取符合要求的所有生产订单（这个是从本地数据库中查出的，动态显示到客户端）
        /// </summary>
        /// <returns></returns>
        Task<ObservableCollection<PRODTABLEDto>> GetProductByStatusAsync();
        /// <summary>
        /// 插入一个生产订单（暂时用不到）
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task PostInsertOneProduct(PRODTABLE input);
        /// <summary>
        /// 删除一个生产订单
        /// </summary>
        /// <param name="prodid"></param>
        void DeleteOneProduct(string prodid);
        /// <summary>
        /// 获取订单的进度（客户端子页面中展示当前进度）
        /// </summary>
        /// <returns></returns>
        Task<ObservableCollection<ProcessInfoDto>> GetRouteProcessAsync(string prodid);
        /// <summary>
        /// 插入一步工序
        /// </summary>
        /// <param name="insertDTO">工序数据</param>
        /// <param name="prodid">工序所在的生产单号</param>
        /// <returns></returns>
        Task<bool> InsertSingleRoute(PRODROUTE insertDTO,string prodid);
    }
}
