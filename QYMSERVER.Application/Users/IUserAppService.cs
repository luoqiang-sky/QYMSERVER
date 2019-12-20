using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using QYMSERVER.Roles.Dto;
using QYMSERVER.Users.Dto;

namespace QYMSERVER.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}