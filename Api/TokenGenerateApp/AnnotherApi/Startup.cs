
using JWTApplication.JWT;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Jwt;
using Owin;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Web;

[assembly: OwinStartup(typeof(TokenGenerateApp.Startup))]

namespace TokenGenerateApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
          JWTMiddleware.ConfigureOAuth(app);            
        }

    }
}
