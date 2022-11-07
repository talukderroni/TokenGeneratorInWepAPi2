using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace JWTApplication.JWT
{
    public class TokenHelper
    {
       static NameValueCollection  myKeys = ConfigurationManager.AppSettings;
        public  static string GetToken()
        {
            string key = myKeys["Key"];
         
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            //Create a List of Claims, Keep claims name short    
            var permClaims = new List<Claim>();
            permClaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            permClaims.Add(new Claim("userid", "1"));
         
            //Create Security Token object by giving required parameters    
            var token = new JwtSecurityToken(myKeys["Issuer"], //Issure    
                             myKeys["Audience"],  //Audience    
                            permClaims,
                            expires: DateTime.Now.AddMinutes(1),

                            signingCredentials: credentials);
            var jwt_token = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt_token;
        }

    }
}
