using System.Threading.Tasks;
using Abp.Application.Services;
using QYMSERVER.Authorization.Accounts.Dto;

namespace QYMSERVER.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
