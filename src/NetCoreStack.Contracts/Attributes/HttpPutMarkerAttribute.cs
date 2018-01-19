using System;

namespace NetCoreStack.Contracts
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public sealed class HttpPutMarkerAttribute : HttpMethodMarkerAttribute
    {
        public ContentType ContentType { get; set; }

        public HttpPutMarkerAttribute()
        {
        }
    }
}
