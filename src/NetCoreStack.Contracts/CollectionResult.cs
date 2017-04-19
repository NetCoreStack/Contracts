using Newtonsoft.Json;
using System.Collections.Generic;

namespace NetCoreStack.Contracts
{
    public abstract class CollectionResultBase
    {
        [JsonProperty("draw")]
        public int Draw { get; set; }

        [JsonProperty("recordsTotal")]
        public long TotalRecords { get; set; }

        [JsonProperty("recordsFiltered")]
        public long TotalRecordsFiltered { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }
    }
    
    public class CollectionResult<T> : CollectionResultBase
    {
        public IEnumerable<T> Data { get; set; }
    }
}
