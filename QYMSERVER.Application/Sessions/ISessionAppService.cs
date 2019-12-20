using System.Threading.Tasks;
using Abp.Application.Services;
using QYMSERVER.Sessions.Dto;

namespace QYMSERVER.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
