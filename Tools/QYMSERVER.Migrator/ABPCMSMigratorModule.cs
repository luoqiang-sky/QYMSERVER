using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using QYMSERVER.EntityFramework;

namespace QYMSERVER.Migrator
{
    [DependsOn(typeof(QYMSERVERDataModule))]
    public class QYMSERVERMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<QYMSERVERDbContext>(null);

          //  Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}