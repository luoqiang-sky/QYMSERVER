using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using QYMSERVER.Configuration.Dto;

namespace QYMSERVER.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : QYMSERVERAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
