using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraveFish.Base
{
    public static class BaseControllerExtensions
    {
        public static IMvcBuilder ConfigureApiToBaseBehaviour(this IMvcBuilder mvc, ApiBaseBehaviourConfiguration config)
        {
            mvc.ConfigureApiBehaviorOptions(opt =>
            {
                opt.InvalidModelStateResponseFactory = context =>
                {
                    return new OkObjectResult(ResponseWrapper.WrapFailure(config.InvalidModelStateResponseStatus));
                };
            });

            return mvc;
        }
    }
}
