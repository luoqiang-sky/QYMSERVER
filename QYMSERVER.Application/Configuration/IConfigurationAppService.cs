using System.Threading.Tasks;
using Abp.Application.Services;
using QYMSERVER.Configuration.Dto;

namespace QYMSERVER.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}