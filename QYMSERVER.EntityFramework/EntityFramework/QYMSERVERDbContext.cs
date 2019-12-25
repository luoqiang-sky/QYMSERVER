using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Data.Entity;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
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
            //以下操作是每次都会删除数据库并重新创建。实际上多用nuget控制台Add-Migration v1 Update-Database指令来进行数据库迁移
            //Database.SetInitializer<QYMSERVERDbContext>(new DropCreateDatabaseIfModelChanges<QYMSERVERDbContext>()); 
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
        public IDbSet<TaskK> Tasks { get; set; }
    }
    public class TaskK : Entity, IHasCreationTime
    {
 
        public long? AssignePersonId { get; set; }

        [ForeignKey("AssignePersonId")]
        public User AssignePerson { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }


        public DateTime CreationTime { get; set; }
        public TaskK()
        {
            CreationTime = DateTime.Now;
        }

        public TaskK(string title, string description = null) : this()
        {
            Title = title;
            Description = description;
        }

    }
}
