using Abp.Domain.Services;
using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.OPC_UA
{
    public interface IAssignWorkManager: IDomainService
    {
        void AssignTaskToRobot();

        void RobotMultipleSubscription();
        void RemoveRobotMultipleSubscription();

        void ReadSingleNode(NodeId nodeId);
        void ReadMultipleNode(string[] nodeIds);
    }
}
