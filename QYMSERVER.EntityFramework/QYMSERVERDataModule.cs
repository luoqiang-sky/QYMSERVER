using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using QYMSERVER.EntityFramework;

namespace QYMSERVER
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(QYMSERVERCoreModule))]
    public class QYMSERVERDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<QYMSERVERDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
