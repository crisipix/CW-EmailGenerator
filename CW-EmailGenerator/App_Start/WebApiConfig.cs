using CW_EmailGenerator.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CW_EmailGenerator.App_Start
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Start up logging
            log4net.Config.XmlConfigurator.Configure();

            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Elmah Filters
            config.Filters.Add(new ElmahHandleWebApiErrorAttribute());
        }
    }
}