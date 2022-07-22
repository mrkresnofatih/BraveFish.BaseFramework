using BraveFish.Base;
using BraveFish.SampleAPI.Exceptions;

namespace BraveFish.SampleAPI.Utils
{
    public static class ExceptionHandler
    {
        public static void UseAppExceptionHandler(this IApplicationBuilder app)
        {
            var exceptionHandlerConfig = new BraveFishExceptionHandlerConfigurationBuilder()
                .SetContentType("application/json")
                .SetStatusCode(200)
                .SetUnhandledStatusCode(400)
                .SetUnhandledStatus("UnhandledError")

                .AddExceptionToHandle(typeof(RecordNotFoundException), "BadRequest")

                .Build();
            app.UseBaseExceptionHandler(exceptionHandlerConfig);
        }
    }
}
