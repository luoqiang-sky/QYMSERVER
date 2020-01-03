using System.Collections.Generic;
using QYMSERVER.Roles.Dto;
using QYMSERVER.Users.Dto;

namespace QYMSERVER.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}