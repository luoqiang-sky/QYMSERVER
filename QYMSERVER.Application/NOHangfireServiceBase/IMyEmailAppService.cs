using System.Threading.Tasks;

namespace QYMSERVER.HangfireServiceBase
{
    internal interface IMyEmailAppService
    {
        Task SendEmail(SendEmailInput input);
    }
}