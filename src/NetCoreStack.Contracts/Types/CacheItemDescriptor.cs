using System;

namespace NetCoreStack.Contracts
{
    public class CacheItemDescriptor
    {
        public Type Type { get; set; }
        public CacheItemWeights Weight { get; set; }

        public CacheItemDescriptor()
        {
            Weight = CacheItemWeights.LightWeight;
        }
    }
}
