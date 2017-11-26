using Autofac;
using EmailGenerator.DataAccess.Repositories;
using EmailGenerator.DataAccess.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailGenerator.DataAccess.Configs
{
    public class DataAccessServiceConfig
    {
        public static void RegisterServices(ContainerBuilder builder)
        {
            // Usually you're only interested in exposing the type
            // http://stackoverflow.com/questions/15226536/register-generic-type-with-autofac
            // via its interface:
            builder.RegisterType<PersonService>().As<IPersonService>();

            builder.RegisterType<PersonRepository>().As<IPersonRepository>();

            // Provider
            //builder.RegisterType<HttpClientProvider>().As<IHttpClientProvider>();

        }
    }
}
