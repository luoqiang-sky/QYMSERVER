using Abp.Domain.Services;
using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.MainWork.MPS
{
    public interface IAssignWorkManager: IDomainService
    {

        void AssignWorkCore();//监控&&计算获取需要下发的生产订单
        void AssignTaskToRobot();//将生产订单转化成工序订单，并持久化管理

        void RobotMultipleSubscription();
        void RemoveRobotMultipleSubscription();

        void ReadSingleNode(NodeId nodeId);
        void ReadMultipleNode(string[] nodeIds);
    }
}
