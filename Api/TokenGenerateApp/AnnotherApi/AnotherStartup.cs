using JWTApplication.JWT;
using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(AnnotherApi.AnotherStartup))]

namespace AnnotherApi
{
    public class AnotherStartup
    {
        public void Configuration(IAppBuilder app)
        {
            JWTMiddleware.ConfigureOAuth(app);
        }
    }
}
