using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraveFish.Base
{
    public class ResponseWrapper
    {
        public static BaseResponseModel<T> WrapSuccess<T>(T data)
        {
            return new BaseResponseModel<T>
            {
                Data = data,
                Status = null
            };
        }

        public static BaseResponseModel<object> WrapFailure(string status)
        {
            return new BaseResponseModel<object>
            {
                Data = null,
                Status = status
            };
        }
    }
}
