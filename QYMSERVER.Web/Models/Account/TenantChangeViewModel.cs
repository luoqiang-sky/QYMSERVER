using Abp.AutoMapper;
using QYMSERVER.Sessions.Dto;

namespace QYMSERVER.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}