using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraveFish.Base
{
    public interface IBraveFishExceptionHandlerConfigurationBuilder
    {
        public IBraveFishExceptionHandlerConfigurationBuilder SetStatusCode(int statusCode);

        public IBraveFishExceptionHandlerConfigurationBuilder SetUnhandledStatusCode(int unhandledStatusCode);

        public IBraveFishExceptionHandlerConfigurationBuilder SetContentType(string contentType);

        public IBraveFishExceptionHandlerConfigurationBuilder SetUnhandledStatus(string unhandledStatus);

        public IBraveFishExceptionHandlerConfigurationBuilder AddExceptionToHandle(Type exceptionType, string handlerStatus);

        public IBraveFishExceptionHandlerConfigurationBuilder AddExceptionsToHandle(Dictionary<Type, string> exceptionHandlerStatusPairs);

        public BraveFishExceptionHandlerConfiguration Build();
    }
}
