using System;
using System.Reflection;
using Abp.Hangfire;
using Abp.Hangfire.Configuration;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Modules;
using Abp.Threading.BackgroundWorkers;
using Abp.Zero;
using Abp.Zero.Configuration;
using Hangfire;
using OpcUaHelper;
using QYMSERVER.Authorization;
using QYMSERVER.Authorization.Roles;
using QYMSERVER.Authorization.Users;
using QYMSERVER.Configuration;
using QYMSERVER.MultiTenancy;
using QYMSERVER.PeriodicBackgroundWork;

namespace QYMSERVER
{
    [DependsOn(typeof(AbpZeroCoreModule), typeof(AbpHangfireModule))]
    public class QYMSERVERCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            InitOPC();

            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            //Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            //Remove the following line to disable multi-tenancy.
            Configuration.MultiTenancy.IsEnabled = QYMSERVERConsts.MultiTenancyEnabled;

            //Add/remove localization sources here
            Configuration.Localization.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    QYMSERVERConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        Assembly.GetExecutingAssembly(),
                        "QYMSERVER.Localization.Source"
                        )
                    )
                );

            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Authorization.Providers.Add<QYMSERVERAuthorizationProvider>();

            Configuration.Settings.Providers.Add<AppSettingProvider>();

            Configuration.Authorization.Providers.Add<UserInfoAuthorizationProvider>();

        }
        public override void PostInitialize()
        {
            //注册后台工作者
            var workManager = IocManager.Resolve<IBackgroundWorkerManager>();
            workManager.Add(IocManager.Resolve<ProductTableMonitorWorker>());
        }

        public static OpcUaClient m_OpcUaClient;

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
        private async void InitOPC()
        {
            m_OpcUaClient = new OpcUaClient();
            try
            {
                await m_OpcUaClient.ConnectServer("opc.tcp://118.24.36.220:62547/DataAccessServer");
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
        }
}
}
