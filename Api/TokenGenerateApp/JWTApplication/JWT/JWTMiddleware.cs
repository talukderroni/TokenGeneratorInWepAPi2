using Microsoft.IdentityModel.Tokens;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Jwt;
using Owin;
using System.Collections.Specialized;
using System.Configuration;
using System.Text;


namespace JWTApplication.JWT
{
    public  class JWTMiddleware
    {
        public static void ConfigureOAuth(IAppBuilder app)
        {
            NameValueCollection myKeys = ConfigurationManager.AppSettings;
            
             var Key = myKeys["Key"];

               app.UseJwtBearerAuthentication(
                  new JwtBearerAuthenticationOptions
                  {
                      AuthenticationMode = AuthenticationMode.Active,
                      TokenValidationParameters = new TokenValidationParameters()
                      {
                          ValidateIssuer = true,
                          ValidateAudience = true,
                          ValidateIssuerSigningKey = true,
                          ValidIssuer = myKeys["Issuer"] ,//some string, normally web url,  
                          ValidAudience =myKeys["Audience"],
                          IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(myKeys["Key"]))
                      }
                  });
        }
    }
}
  
