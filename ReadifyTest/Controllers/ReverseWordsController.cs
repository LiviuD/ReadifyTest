using ReadifyTest.Code;
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
    public class ReverseWordsController : BaseApiController
    {
        //[CacheWebApi(Duration = 1)]
        public HttpResponseMessage Get(string sentence)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK, ReverseSentence(sentence));
            return response;
        }

        private string ReverseSentence(string sentence)
        {
           return sentence
                .Split(' ')
                .ToList()
                .Select(w => ReverseWord(w))
                .Aggregate((w1, w2) => $"{w1} {w2}");
        }

        private string ReverseWord (string word)
        {
            var sb = new StringBuilder(word);
            var i = 0;
            while (i < sb.Length/2)
            {
                if (sb[i] != sb[sb.Length - i - 1])
                {
                    var temp = sb[i];
                    sb[i] = sb[sb.Length - i - 1];
                    sb[sb.Length - i - 1] = temp;
                }
                i++;
            }
            return sb.ToString();
        }
    }
}