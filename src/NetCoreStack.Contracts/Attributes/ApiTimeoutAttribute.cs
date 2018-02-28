using System;

namespace NetCoreStack.Contracts
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public sealed class ApiTimeoutAttribute : Attribute
    {
        public TimeSpan Timeout { get; set; }

        /// <summary>
        /// Timeout seconds
        /// </summary>
        /// <param name="seconds"></param>
        public ApiTimeoutAttribute(int seconds)
        {
            Timeout = TimeSpan.FromSeconds(seconds);
        }
    }
}
