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
    public class TriangleTypeController : BaseApiController<ITriangleService>
    {
        public TriangleTypeController(ITriangleService service) : base(service)
        { }
        [CacheWebApi(Duration = 1)]
        public string Get(int a, int b, int c)
        {
            return service.GetTriangleType(a, b, c);
        }

      
    }
}