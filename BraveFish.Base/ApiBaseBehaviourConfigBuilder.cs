using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraveFish.Base
{
    public class ApiBaseBehaviourConfigBuilder : IApiBaseBehaviourConfigBuilder
    {
        private ApiBaseBehaviourConfiguration _config;

        public ApiBaseBehaviourConfigBuilder()
        {
            _config = new ApiBaseBehaviourConfiguration();
        }

        public ApiBaseBehaviourConfiguration Build()
        {
            return _config;
        }

        public IApiBaseBehaviourConfigBuilder SetInvalidModelStateResponseStatus(string status)
        {
            _config.InvalidModelStateResponseStatus = status;
            return this;
        }
    }
}
