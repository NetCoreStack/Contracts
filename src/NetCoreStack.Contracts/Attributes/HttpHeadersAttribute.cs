using System;

namespace NetCoreStack.Contracts
{
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Method)]
    public class HttpHeadersAttribute : Attribute
    {
        public HttpHeadersAttribute(params string[] headers)
        {
            Headers = headers ?? new string[0];
        }

        public string[] Headers { get; }
    }
}