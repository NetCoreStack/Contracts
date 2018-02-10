using System;

namespace NetCoreStack.Contracts
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public sealed class MethodLogAttribute : Attribute
    {
        public MethodLogAttribute()
        {

        }
    }
}
