using ReadifyTest.Code;
using ReadifyTestServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace ReadifyTest.Controllers
{
    public class FibonacciController : BaseApiController<IFibonacciService>
    {
        public FibonacciController(IFibonacciService _service) : base(_service)
        {
        }

        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.NotFound, "The value is requiered");
        }

        [CacheWebApi(Duration = 1)]
        public HttpResponseMessage Get(int n)
        {
            if (n > 92 || n < -92)//bigger than 92 and it will exceed the int64
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            var response = Request.CreateResponse(HttpStatusCode.OK, service.ComputeFibonacci(n));
            return response;
        }

       
    }
}
