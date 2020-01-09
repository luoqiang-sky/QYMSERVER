using Abp.Application.Services;
using QYMSERVER.DoWork.MainProduct.Dto;
using QYMSERVER.Entities.Product;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.DoWork.MainProduct
{
    public interface IProductRouteAppService: IApplicationService
    {
        PRODROUTEDto GetProductRouteByID(string prodid, string routeid, int num);
        Task<ObservableCollection<PRODROUTEDto>> GetRoutesByIDAsync(string prodid);

        Task InsertOneProductRoute(PRODROUTE input);
        void DeleteOneProduct(string prodid, string routeid, int num);

    }
}
