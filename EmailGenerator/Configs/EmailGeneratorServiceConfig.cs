using Autofac;
using EmailGenerator.Services;
using RazorEngine.Templating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailGenerator.Configs
{
    public class EmailGeneratorServiceConfig
    {
        public static void RegisterServices(ContainerBuilder builder)
        {
            // Usually you're only interested in exposing the type
            // http://stackoverflow.com/questions/15226536/register-generic-type-with-autofac
            // via its interface:
            builder.RegisterType<EmailTemplateService>().As<IEmailTemplateService>();
            builder.RegisterType<TemplateService>().As<ITemplateService>();
            

        }
    }
}
