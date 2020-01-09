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
    public interface ILocalProductTableAppService: IApplicationService
    {
        PRODTABLEDto GetProductByID(string prodid);
        Task<ObservableCollection<PRODTABLEDto>> GetProductByStatusAsync();
        Task PostInsertOneProduct(PRODTABLE input);
        void DeleteOneProduct(string prodid);

        Task<List<ROUTEOPRTABLEDto>> GetRouteProcessAsync();

    }
}
