﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AnnotherApi.Controllers
{
    public class TestController : ApiController
    {
     

        //[HttpGet]
        //public string GetLoginInfo()
        //{
        //    return TokenHelper.GetToken();
        //}

        [Authorize]
        [HttpPost]
        public string GetNameFromAnotherAPI()
        {
            return "ok";
        }
       
    }
}
