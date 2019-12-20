using Abp.Authorization;
using QYMSERVER.Authorization.Roles;
using QYMSERVER.Authorization.Users;

namespace QYMSERVER.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
