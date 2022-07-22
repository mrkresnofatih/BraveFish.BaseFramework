using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraveFish.Base
{
    public static class BaseLoggerExtensions
    {
        public static ILoggingBuilder AddBaseConsoleLogger(this ILoggingBuilder logging)
        {
            var logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console()
                .CreateLogger();
            logging.ClearProviders();
            logging.AddSerilog(logger);

            return logging;
        }
    }
}
