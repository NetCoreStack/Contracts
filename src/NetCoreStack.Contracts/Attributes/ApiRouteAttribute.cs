﻿using System;

namespace NetCoreStack.Contracts.Attributes
{
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    public sealed class ApiRouteAttribute : Attribute
    {
        public string RouteTemplate { get; set; }
        public string RegionKey { get; set; }

        public ApiRouteAttribute(string routeTemplate, string regionKey)
        {
            if (!routeTemplate.HasValue())
                throw new ArgumentNullException(nameof(routeTemplate));

            if (!regionKey.HasValue())
                throw new ArgumentNullException(nameof(regionKey));

            RegionKey = regionKey;
        }
    }
}