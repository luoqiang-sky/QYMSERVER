using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using QYMSERVER.Authorization.Users;
using QYMSERVER.MultiTenancy;
using QYMSERVER.Users;
using Microsoft.AspNet.Identity;

namespace QYMSERVER
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class QYMSERVERAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected QYMSERVERAppServiceBase()
        {
            LocalizationSourceName = QYMSERVERConsts.LocalizationSourceName;
        }

        protected virtual async Task<User> GetCurrentUserAsync()
        {
            var user = await UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}