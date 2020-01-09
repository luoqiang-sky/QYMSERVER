using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.DoWork.AssignTask.OPCInterface
{
    public interface IOpcInterfaceAppService: IApplicationService
    {
        //测试Dimain层的opc功能
        void GetOPCInterface();
    }
}
