using System.Collections.Generic;

namespace NetCoreStack.Contracts
{
    public class AutoCompleteRequest : CollectionRequest
    {
        public long? EntityId { get; set; }
        public long? ParentId { get; set; }
        public string Regex { get; set; }
        public IEnumerable<string> SelectedIds { get; set; }
        public bool? InitialValues { get; set; }

        public AutoCompleteRequest()
        {
            SelectedIds = new List<string>();
        }
    }
}
