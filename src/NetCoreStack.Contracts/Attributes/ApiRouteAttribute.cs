using System;

namespace NetCoreStack.Contracts
{
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    public sealed class ApiRouteAttribute : Attribute
    {
        public string RouteTemplate { get; set; }
        public string RegionKey { get; set; }

        public ApiRouteAttribute(string routeTemplate, string regionKey)
        {
            if (string.IsNullOrEmpty(routeTemplate))
                throw new ArgumentNullException(nameof(routeTemplate));

            if (string.IsNullOrEmpty(regionKey))
                throw new ArgumentNullException(nameof(regionKey));

            RegionKey = regionKey;
        }
    }
}