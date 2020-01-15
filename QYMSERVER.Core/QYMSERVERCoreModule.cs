using System;
using System.Reflection;
using Abp.Domain.Repositories;
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
using QYMSERVER.Entities.Product;
using QYMSERVER.MainWork.Basic;
using QYMSERVER.MultiTenancy;
using QYMSERVER.OPC_UA;
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

            Abp.Dependency.IocManager.Instance.Register<IBasicWorkCore,BasicWorkCore>();//注册一个对象
            var bwk= Abp.Dependency.IocManager.Instance.Resolve<IBasicWorkCore>();//解析一个对象
            Abp.Dependency.IocManager.Instance.Release(bwk);//释放对象 防止内存泄露
        }

        public static OpcUaClient A_OpcUaClient;
        public static OpcUaClient B_OpcUaClient;
        public static OpcUaClient C_OpcUaClient;
        //private  IRepository<PRODTABLE> _PRODTABLERepository;
        //private readonly IRepository<PRODROUTE> _PRODROUTERepository;
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            OpcBasicMonitorWorkManager opcBasicMonitorWorkManager = new OpcBasicMonitorWorkManager();
        }
        private async void InitOPC()
        {
            A_OpcUaClient = new OpcUaClient();
            B_OpcUaClient = new OpcUaClient();
            C_OpcUaClient = new OpcUaClient();
            try
            {
                await A_OpcUaClient.ConnectServer("opc.tcp://118.24.36.220:62547/DataAccessServer");
            }
            catch (Exception ex)
            {
                Logger.Error("A_OpcUaClient -" + ex.Message);
            }
            try
            {
                await B_OpcUaClient.ConnectServer("opc.tcp://118.24.36.220:62547/DataAccessServer");
            }
            catch (Exception ex)
            {
                Logger.Error("B_OpcUaClient -" + ex.Message);
            }
            try
            {
                await C_OpcUaClient.ConnectServer("opc.tcp://118.24.36.220:62547/DataAccessServer");
            }
            catch (Exception ex)
            {
                Logger.Error("C_OpcUaClient -" + ex.Message);
            }
        }
}
}
