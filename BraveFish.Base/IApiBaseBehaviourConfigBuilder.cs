using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraveFish.Base
{
    public interface IApiBaseBehaviourConfigBuilder
    {
        IApiBaseBehaviourConfigBuilder SetInvalidModelStateResponseStatus(string status);

        ApiBaseBehaviourConfiguration Build();
    }
}
