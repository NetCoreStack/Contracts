using System.Collections.Generic;

namespace NetCoreStack.Contracts
{
    public class IdTextPairDescriptor
    {
        public string Metadata { get; set; }
        public IEnumerable<IdTextPair> Items { get; set; }
    }
}
