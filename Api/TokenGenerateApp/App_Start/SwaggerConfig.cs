using System.Web.Http;
using WebActivatorEx;
using TokenGenerateApp;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace TokenGenerateApp
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;
           // GlobalConfiguration.Configuration
           //.EnableSwagger(c => c.SingleApiVersion("v1", "First WEB API Demo"))
           //.EnableSwaggerUi();
        }
    }
}
