using System;
using System.Threading;
using Abp.Castle.Logging.Log4Net;
using Abp.Web;
using Abp.WebApi.Validation;
using Castle.Facilities.Logging;
using System.Web.Mvc;
using System.Web.Routing;
using Hangfire.Logging;
using QYMSERVER.Web.App_Start;

namespace QYMSERVER.Web
{
    public class MvcApplication : AbpWebApplication<QYMSERVERWebModule>
    {
        protected override void Application_Start(object sender, EventArgs e)
        {
            //AreaRegistration.RegisterAllAreas();
            //RouteConfig.RegisterRoutes(RouteTable.Routes);

            //LogProvider.SetCurrentLogProvider(new TextBufferLogProvider());
            //TextBuffer.WriteLine("Application started.");

            AbpBootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(
                f => f.UseAbpLog4Net().WithConfig(Server.MapPath("log4net.config"))
            );
            
            base.Application_Start(sender, e);

          
        }

    }
}
