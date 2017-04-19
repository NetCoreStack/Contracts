namespace NetCoreStack.Contracts
{
    public class OrderDescriptor
    {
        public int ColumnIndex { get; set; }

        public ListSortDirection Direction { get; set; }

        public OrderDescriptor(int columnIndex, ListSortDirection direction)
        {
            ColumnIndex = columnIndex;
            Direction = direction;
        }
    }

    public class OrderMemberDescriptor
    {
        public string Member { get; set; }

        public string Direction { get; set; }

        public ListSortDirection ListSortDirection { get; set; }
    }
}