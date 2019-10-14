namespace NetCoreStack.Contracts
{
    public class ColumnOrderDescriptor
    {
        public int ColumnIndex { get; set; }

        public string Name { get; set; }

        public ListSortDirection Direction { get; set; }
    }
}