
using JWTApplication.JWT;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Web.Http;

namespace TokenGenerateApp.Controllers
{
    public class LoginPageController : ApiController
    {

        [HttpGet]
        public string GetLoginInfo()
        {
            return  TokenHelper.GetToken();
        }

        [Authorize]  
        [HttpPost]
        public string GetName()
        {
            return "ok";
        }
       
    }
}
