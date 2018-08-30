using ReadifyTest.Code;
using ReadifyTestServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReadifyTest.Controllers
{
    //[CheckApiKey]
    public abstract class BaseApiController: ApiController 
    {

    }

    public abstract class BaseApiController<TService> : BaseApiController where TService : IReadifyTestService
    {
        public BaseApiController()
        {

        }
        protected TService service;
        public BaseApiController(TService service)
        {
            this.service = service;
        }
    }


}