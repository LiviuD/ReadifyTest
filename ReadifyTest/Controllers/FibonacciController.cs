using ReadifyTest.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace ReadifyTest.Controllers
{
    public class FibonacciController : BaseApiController
    {
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.NotFound, "The value is requiered");
        }

        //[CacheWebApi(Duration = 1)]
        public HttpResponseMessage Get(int n)
        {
            if(n > 100)
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            var response = Request.CreateResponse(HttpStatusCode.OK, ComputeFibonacci(n));
            return response;
        }

        private int ComputeFibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
