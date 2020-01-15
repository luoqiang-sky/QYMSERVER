using System.Collections.Generic;
using Abp.Configuration;

namespace QYMSERVER.Configuration
{
    public class AppSettingProvider : SettingProvider
    {
        public override IEnumerable<SettingDefinition> GetSettingDefinitions(SettingDefinitionProviderContext context)
        {
            return new[]
            {
                        new SettingDefinition(AppSettingNames.UiTheme, "red", scopes: SettingScopes.Application | SettingScopes.Tenant | SettingScopes.User, isVisibleToClients: true),
                        new SettingDefinition(
                        "A_OPCAddress",
                        "opc.tcp://118.24.36.220:62547/DataAccessServer"
                        ),
                        new SettingDefinition(
                        "B_OPCAddress",
                        "opc.tcp://118.24.36.220:62547/DataAccessServer"
                        ),
                        new SettingDefinition(
                        "C_OPCAddress",
                        "opc.tcp://118.24.36.220:62547/DataAccessServer"
                        ),
                        new SettingDefinition(
                        "D_OPCAddress",
                        "127.0.0.1"
                        ),
                        new SettingDefinition(
                        "E_OPCAddress",
                        "127.0.0.1"
                        ),

            };
        }
    }
}