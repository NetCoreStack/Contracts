using System.Collections.Generic;

namespace NetCoreStack.Contracts
{
    public abstract class CollectionResultBase
    {
        public int Draw { get; set; }
        
        public long RecordsTotal { get; set; }
        
        public long RecordsFiltered { get; set; }

        public object Error { get; set; }
    }
    
    public class CollectionResult<T> : CollectionResultBase
    {
        public IEnumerable<T> Data { get; set; }
    }
}
