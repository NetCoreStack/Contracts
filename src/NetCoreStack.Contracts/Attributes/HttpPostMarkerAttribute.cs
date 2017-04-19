using System;

namespace NetCoreStack.Contracts
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public sealed class HttpPostMarkerAttribute : HttpMethodMarkerAttribute
    {
        public HttpPostMarkerAttribute()
        {
        }
    }
}