using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using QYMSERVER.ClientService.MPS;
using QYMSERVER.Entities.Product;

namespace QYMSERVER.ClientService.MPS
{
    /// <summary>
    /// 工序操作接口
    /// </summary>
    public class RouteWorkAppService : QYMSERVERAppServiceBase, IRouteWorkAppService
    {
        private readonly IRepository<PRODROUTE> _PRODROUTERepository;
        public RouteWorkAppService(IRepository<PRODROUTE> repository)
        {
            _PRODROUTERepository = repository;
        }
        public async Task DeleteOneRoute(string prodid,string routeid,int num)
        {
            var temp =  _PRODROUTERepository.FirstOrDefault(pro => pro.PRODID == prodid &&pro.OPRID==routeid&&pro.LEVEL_ == num);

            if (temp != null)
            {
                _PRODROUTERepository.Delete(temp);
            }
        }

        public PRODROUTEDto GetProductRouteByID(string prodid, string routeid, int num)
        {
            var temp = _PRODROUTERepository.FirstOrDefault(pro => pro.PRODID == prodid && pro.OPRID == routeid && pro.LEVEL_ == num);
            return temp.MapTo<PRODROUTEDto>();
        }

        public async Task<ObservableCollection<PRODROUTEDto>> GetRoutesByIDAsync(string prodid)
        {
            var temp = _PRODROUTERepository.GetAll().Where(p => p.PRODID == prodid).OrderBy(p => p.OPRNUM).ToList();
            return temp.MapTo<ObservableCollection<PRODROUTEDto>>();
        }

        public async Task InsertOneProductRoute(PRODROUTEDto input)
        {
            await _PRODROUTERepository.InsertAndGetIdAsync(input.MapTo< PRODROUTE>());
        }

        public async Task ModifyOneRoute(string prodid, string routeid, int num, string WorkCenterValue)
        {
            var temp = await _PRODROUTERepository.FirstOrDefaultAsync(pro => pro.PRODID == prodid && pro.OPRID == routeid && pro.LEVEL_ == num);
            if (temp != null)
            {
                temp.WRKCTRID = WorkCenterValue;
                _PRODROUTERepository.Update(temp);
            }
        }
        /// <summary>
        /// 计算当前工序可选工作中心
        /// </summary>
        /// <param name="prodid"></param>
        /// <param name="routeid"></param>
        /// <returns></returns>
        public Task<List<string>> CalcRouteWorkCenters(string prodid, string routeid)
        {
            throw new NotImplementedException(); //???  工作中心计算比较麻烦 后面再搞     大体思路：设备三大表+Machines设备状态
        }
    }
}
