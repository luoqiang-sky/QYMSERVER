using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace QYMSERVER.AX
{
    public interface IGetAXWorkManger : IDomainService
    {
        void GetProductTableFromAX();//从ax上获取订单数据
        void GetParameterTableFromAX(string prodid);//从ax上获取订单数据的配套参数信息
        void GetBasicDataFromAX();//从ax上获取基础数据
    }
}
