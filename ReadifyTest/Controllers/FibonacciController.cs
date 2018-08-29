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
            if (n > 92 || n < -92)//bigger than 92 and it will exceed the int64
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            var response = Request.CreateResponse(HttpStatusCode.OK, ComputeFibonacci(n));
            return response;
        }

        private long ComputeFibonacci(int n)
        {
            var numerator = Math.Pow((1.0 + Math.Sqrt(5.0)), n) 
                            - Math.Pow((1.0 - Math.Sqrt(5.0)), n);
            var denominator = Math.Pow(2.0, n) * Math.Sqrt(5.0);
            var result = numerator / denominator;

            var roundedResult = Math.Round(result);

            return (long)roundedResult;
        }
    }
}
