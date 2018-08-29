using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Configuration;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace ReadifyTest.Code
{
    /// <summary>
    /// Filter to check if the api_key query sring is present and has the proper value
    /// </summary>
    /// <seealso cref="System.Web.Http.Filters.ActionFilterAttribute" />
    public class CheckApiKeyAttribute : ActionFilterAttribute
    {
        internal readonly static string Key = "api_key";
        internal readonly string Value = "f885f89e-3041-457f-b138-372c3c8c5943";

        public CheckApiKeyAttribute()
        {
            Value = WebConfigurationManager.AppSettings[Key];
        }

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (!actionContext.ControllerContext.Request.GetQueryNameValuePairs().Any(x => x.Key.ToLower() == Key)
                || actionContext.ControllerContext.Request.GetQueryNameValuePairs().First(x => x.Key.ToLower() == Key).Value.ToLower() != Value)
            {
                    actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Forbidden, "Api key is not valid or missing");
                return;
            }
            base.OnActionExecuting(actionContext);
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            return;
        }
    }
}