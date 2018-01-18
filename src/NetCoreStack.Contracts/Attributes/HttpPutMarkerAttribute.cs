using System;

namespace NetCoreStack.Contracts
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public sealed class HttpPutMarkerAttribute : HttpMethodMarkerAttribute
    {
        public bool IsMultipartFormData { get; set; }

        public HttpPutMarkerAttribute()
        {
        }
    }
}
