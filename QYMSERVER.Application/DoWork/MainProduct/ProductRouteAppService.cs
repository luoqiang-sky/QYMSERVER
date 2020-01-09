using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using QYMSERVER.DoWork.MainProduct.Dto;
using QYMSERVER.Entities.Product;

namespace QYMSERVER.DoWork.MainProduct
{
    public class ProductRouteAppService : QYMSERVERAppServiceBase, IProductRouteAppService
    {
        private readonly IRepository<PRODROUTE> _PRODROUTERepository;
        public ProductRouteAppService(IRepository<PRODROUTE> repository)
        {
            _PRODROUTERepository = repository;
        }
        public void DeleteOneProduct(string prodid,string routeid,int num)
        {
            var temp = _PRODROUTERepository.FirstOrDefault(pro => pro.PRODID == prodid &&pro.OPRID==routeid&&pro.OPRNUM==num);

            if (temp != null)
            {
                _PRODROUTERepository.Delete(temp);
            }
        }

        public PRODROUTEDto GetProductRouteByID(string prodid, string routeid, int num)
        {
            var temp = _PRODROUTERepository.FirstOrDefault(pro => pro.PRODID == prodid && pro.OPRID == routeid && pro.OPRNUM == num);
            return temp.MapTo<PRODROUTEDto>();

        }

        public async Task<ObservableCollection<PRODROUTEDto>> GetRoutesByIDAsync(string prodid)
        {
            var temp =  _PRODROUTERepository.GetAll().Where(p => p.PRODID == prodid).OrderBy(p => p.OPRNUM).ToList();
            return temp.MapTo<ObservableCollection<PRODROUTEDto>>();
        }

        public async Task InsertOneProductRoute(PRODROUTE input)
        {
            await _PRODROUTERepository.InsertAndGetIdAsync(input);
        }
    }
}
