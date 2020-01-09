using Hangfire;
using QYMSERVER.OPC_UA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.DoWork.AssignTask.OPCInterface
{
    public class OpcInterfaceAppService : QYMSERVERAppServiceBase, IOpcInterfaceAppService
    {
        private  AssignWorkManager _AssignWorkDomainService =new AssignWorkManager();
        //public OpcInterfaceAppService(IAssignWorkManager _taskManager)
        //{
        //    _taskManager = _AssignWorkDomainService;
        //}
        public void GetOPCInterface()
        {
            _AssignWorkDomainService.RobotMultipleSubscription();
            RecurringJob.AddOrUpdate("OPCTestApplicationModule", () => _AssignWorkDomainService.ReadMultipleNode(null), Cron.MinuteInterval(1), TimeZoneInfo.Utc);

        }
    }
}
