using System;

namespace NetCoreStack.Contracts
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public sealed class HttpDeleteMarkerAttribute : HttpMethodMarkerAttribute
    {
        public HttpDeleteMarkerAttribute()
        {
        }
    }
}
