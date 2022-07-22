using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraveFish.Base
{
    public class BraveFishExceptionHandlerConfigurationBuilder : IBraveFishExceptionHandlerConfigurationBuilder
    {
        private BraveFishExceptionHandlerConfiguration _configuration;

        public BraveFishExceptionHandlerConfigurationBuilder()
        {
            _configuration = new BraveFishExceptionHandlerConfiguration();
        }

        public IBraveFishExceptionHandlerConfigurationBuilder AddExceptionsToHandle(Dictionary<Type, string> exceptionHandlerStatusPairs)
        {
            foreach(var exceptionHandlerPair in exceptionHandlerStatusPairs)
            {
                _configuration
                    .ExceptionDictionary
                    .Add(exceptionHandlerPair.Key, exceptionHandlerPair.Value);
            }
            return this;
        }

        public IBraveFishExceptionHandlerConfigurationBuilder AddExceptionToHandle(Type exceptionType, string handlerStatus)
        {
            _configuration.ExceptionDictionary.Add(exceptionType, handlerStatus);
            return this;
        }

        public BraveFishExceptionHandlerConfiguration Build()
        {
            return _configuration;
        }

        public IBraveFishExceptionHandlerConfigurationBuilder SetContentType(string contentType)
        {
            _configuration.ContentType = contentType;
            return this;
        }

        public IBraveFishExceptionHandlerConfigurationBuilder SetStatusCode(int statusCode)
        {
            _configuration.StatusCode = statusCode;
            return this;
        }

        public IBraveFishExceptionHandlerConfigurationBuilder SetUnhandledStatus(string unhandledStatus)
        {
            _configuration.UnhandledStatus = unhandledStatus;
            return this;
        }

        public IBraveFishExceptionHandlerConfigurationBuilder SetUnhandledStatusCode(int unhandledStatusCode)
        {
            _configuration.UnhandledStatusCode = unhandledStatusCode;
            return this;
        }
    }
}
