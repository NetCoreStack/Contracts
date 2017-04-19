using System;

namespace NetCoreStack.Contracts
{
    public class ParameterDescriptor
    {
        public string Name { get; set; }

        public Type ParameterType { get; set; }

        public object BindingInfo { get; set; }
    }
}