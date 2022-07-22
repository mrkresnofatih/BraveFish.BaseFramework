using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraveFish.Base
{
    public class BraveFishExceptionHandlerConfiguration
    {
        public Dictionary<Type, string> ExceptionDictionary { get; set; } = new Dictionary<Type, string>();

        public int StatusCode { get; set; } = 200;

        public int UnhandledStatusCode { get; set; } = 400;

        public string ContentType { get; set; } = "application/json";

        public string UnhandledStatus { get; set; } = "Unhandled";
    }
}
