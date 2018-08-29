using ReadifyTest.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;

namespace ReadifyTest.Controllers
{
    public class TokenController : ApiController
    {
        public string Get()
        {
            return WebConfigurationManager.AppSettings[CheckApiKeyAttribute.Key]; 
        }
    }
}