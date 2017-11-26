using CW_EmailGenerator.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Security;
using System.Web.SessionState;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace CW_EmailGenerator
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            // AutoMapperConfig.Configure();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            DIServiceConfig.Register();
            //GlobalConfiguration.Configuration.MessageHandlers.Add(new MessageLoggingHandler());

            //SwaggerConfig.Register(GlobalConfiguration.Configuration);
            /*
             httpConfiguration
             .EnableSwagger(c => c.SingleApiVersion("v1", "A title for your API"))
             .EnableSwaggerUi();
             */
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}