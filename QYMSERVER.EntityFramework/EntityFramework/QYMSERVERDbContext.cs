using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using QYMSERVER.Authorization.Roles;
using QYMSERVER.Authorization.Users;
using QYMSERVER.MultiTenancy;

namespace QYMSERVER.EntityFramework
{
    public class QYMSERVERDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public QYMSERVERDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in QYMSERVERDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of QYMSERVERDbContext since ABP automatically handles it.
         */
        public QYMSERVERDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public QYMSERVERDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public QYMSERVERDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
