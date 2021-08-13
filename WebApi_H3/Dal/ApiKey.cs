using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_H3.Dal
{
    // specified that ApiKeyAttribute will only be used on classes , like Controllers!
    [AttributeUsage(validOn: AttributeTargets.Class)]
    // This class represents ApiKey - inherit from Attribute and IAsyncActionFilter!
    public class ApiKey : Attribute, IAsyncActionFilter
    {
        private const string APIKEYNAME = "ApiKey";
        public async Task OnActionExecutionAsync
               (ActionExecutingContext context, ActionExecutionDelegate next)
        {
            // If the header doesn’t include the ApiKey as key, then it return a 401 Unauthorized response code with a message indicating that the API Key was not provided!
            if (!context.HttpContext.Request.Headers.TryGetValue
                (APIKEYNAME, out var extractedApiKey))
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 401,
                    Content = "Api Key was not provided"
                };
                return;
            }

            IConfiguration appSettings = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();

            string apiKey = appSettings.GetValue<string>(APIKEYNAME);

            // If the header doesn’t include the right ApiKey, then it return a 401 Unauthorized response code with a message indicating that the API Key was not valid!
            if (!apiKey.Equals(extractedApiKey))
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 401,
                    Content = "Api Key is not valid  -  Unauthorized client"
                };
                return;
            }

            await next();
        }
    }
}
