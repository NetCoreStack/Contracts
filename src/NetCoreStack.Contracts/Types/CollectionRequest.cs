using System.Collections.Generic;

namespace NetCoreStack.Contracts
{
    public class CollectionRequest
    {
        public string Metadata { get; set; }
        
        public int Draw { get; set; }
        
        public int Length { get; set; }
        
        public int Start { get; set; }

        public string Text { get; set; }
        
        public Search Search { get; set; }

        public string Filters { get; set; }

        public IEnumerable<ColumnOrder> Order { get; set; }

        public IEnumerable<Column> Columns { get; set; }
    } 
}