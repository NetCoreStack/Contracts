﻿using System;

namespace NetCoreStack.Contracts
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public abstract class HttpMethodMarkerAttribute : Attribute
    {
        public string Template { get; set; }

        public HttpMethodMarkerAttribute()
        {
        }
    }
}