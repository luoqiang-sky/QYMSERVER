using System.Reflection;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Modules;
using QYMSERVER.Authorization.Roles;
using QYMSERVER.Authorization.Users;
using QYMSERVER.Roles.Dto;
using QYMSERVER.Users.Dto;
using Abp.Threading.BackgroundWorkers;
using Abp.Runtime.Caching;
using Abp.Runtime.Caching.Redis;
using Abp.Hangfire;
using Abp.Quartz;
using QYMSERVER.HangfireServiceBase;
using Quartz;
using Abp.Quartz.Configuration;
using QYMSERVER.Entities.Product;
using QYMSERVER.Entities.IWS;
using Hangfire;
using System;
using QYMSERVER.ClientService.MPS;

namespace QYMSERVER
{
    [DependsOn(typeof(QYMSERVERCoreModule), typeof(AbpAutoMapperModule),
                  typeof(AbpHangfireModule)
          // typeof(HangFireWorkerModule) //- ENABLE TO USE HANGFIRE INSTEAD OF DEFAULT JOB MANAGER
          //typeof(AbpRedisCacheModule),
        //typeof(AbpQuartzModule)

        )]
    public class QYMSERVERApplicationModule : AbpModule 
    {

        public override void PreInitialize()
        {
            base.PreInitialize();
            //IocManager.Register<ICacheManager, AbpRedisCacheManager>();
            //如果Redis在本机,并且使用的默认端口,下面的代码可以不要
            //Configuration.Modules.AbpRedisCacheModule().ConnectionStringKey = "KeyName";

            //Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            //{
            //    mapper.AddProfile<ScheduleProfile>();
            //});

            //Configuration.BackgroundJobs.UseHangfire(configuration =>
            //{
            //    configuration.GlobalConfiguration.UseSqlServerStorage("Default");
            //});
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            // TODO: Is there somewhere else to store these, with the dto classes
            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                // Role and permission
                cfg.CreateMap<Permission, string>().ConvertUsing(r => r.Name);
                cfg.CreateMap<RolePermissionSetting, string>().ConvertUsing(r => r.Name);

                cfg.CreateMap<CreateRoleDto, Role>().ForMember(x => x.Permissions, opt => opt.Ignore());
                cfg.CreateMap<RoleDto, Role>().ForMember(x => x.Permissions, opt => opt.Ignore());
                
                cfg.CreateMap<UserDto, User>();
                cfg.CreateMap<UserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());

                cfg.CreateMap<CreateUserDto, User>();
                cfg.CreateMap<CreateUserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());

                cfg.CreateMap<PRODTABLEDto, PRODTABLE>();
                cfg.CreateMap<PRODTABLEDto, PRODTABLE>().ForMember(x => x.PRODID, opt => opt.Ignore());

                cfg.CreateMap<ROUTEOPRTABLEDto, ROUTEOPRTABLE>();
                cfg.CreateMap<ROUTEOPRTABLEDto, ROUTEOPRTABLE>().ForMember(x => x.OPRID, opt => opt.Ignore());

                cfg.CreateMap<PRODROUTEDto, PRODROUTE>();
                cfg.CreateMap<PRODROUTEDto, PRODROUTE>().ForMember(x => x.PRODID, opt => opt.Ignore());
                //// 创建Job
                //IScheduler scheduler = Configuration.Modules.AbpQuartz().Scheduler;

                //var missionJob = scheduler.GetJobDetail(new JobKey("missionJob", "OfficeGroup"));
                //if (missionJob == null)
                //{
                //    missionJob = JobBuilder.Create<MissionJob>()
                //        .WithIdentity("missionJob", "OfficeGroup")
                //        .WithDescription("执行定时任务")
                //        .StoreDurably(true)
                //        .Build();

                //    scheduler.AddJob(missionJob, true);
                //}
            });
        }
        public override void PostInitialize()
        {
            //注册后台工作者标记消极用户
            var workManager = IocManager.Resolve<IBackgroundWorkerManager>();
            workManager.Add(IocManager.Resolve<MakeInactiveUsersPassiveWorker>());

            //RecurringJob.AddOrUpdate("QYMSERVERApplicationModule", () => dowork(), Cron.MinuteInterval(1), TimeZoneInfo.Utc);
            //RecurringJob.AddOrUpdate("2QYMSERVERApplicationModule", () => dowork(), Cron.MinuteInterval(1), TimeZoneInfo.Utc);

            //var workManager1 = IocManager.Resolve<IBackgroundWorkerManager>();
            //workManager1.Add(IocManager.Resolve<ProductTableMonitorWorker>());
        }
        public void dowork()
        {
            Logger.Error("Fuccck");
        }
    }
}
