namespace BraveFish.Base
{
    public class BaseResponseModel<T>
    {
        public T Data { get; set; }

        public string Status { get; set; }
    }
}