using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraveFish.Base
{
    public static class BraveFishExceptionHandler
    {
        public static void UseBaseExceptionHandler(this IApplicationBuilder app, BraveFishExceptionHandlerConfiguration config)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    var exception = context
                        .Features
                        .Get<IExceptionHandlerPathFeature>()
                        .Error;
                    var exceptionType = exception.GetType();
                    var exceptionList = config.ExceptionDictionary;

                    var exceptionKnown = exceptionList.ContainsKey(exceptionType);
                    var status = exceptionKnown ?
                        exceptionList[exceptionType] : config.UnhandledStatus;

                    var code = exceptionKnown ? config.StatusCode : config.UnhandledStatusCode;

                    context.Response.StatusCode = code;
                    context.Response.ContentType = config.ContentType;

                    await context.Response.WriteAsync(JsonConvert.SerializeObject(ResponseWrapper.WrapFailure(status)));
                });
            });
        }
    }
}
