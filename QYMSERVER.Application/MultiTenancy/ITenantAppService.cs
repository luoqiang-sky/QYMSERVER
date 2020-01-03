using Abp.Application.Services;
using Abp.Application.Services.Dto;
using QYMSERVER.MultiTenancy.Dto;

namespace QYMSERVER.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
