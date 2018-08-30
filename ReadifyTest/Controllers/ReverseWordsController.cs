using ReadifyTest.Code;
using ReadifyTestServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Http;

namespace ReadifyTest.Controllers
{
    public class ReverseWordsController : BaseApiController<IReverseWordService>
    {
        public ReverseWordsController(IReverseWordService service) : base(service)
        { }

        [CacheWebApi(Duration = 1)]
        public HttpResponseMessage Get(string sentence)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK, service.ReverseSentence(sentence));
            return response;
        }

      
    }
}