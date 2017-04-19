namespace NetCoreStack.Contracts
{
    public class Column
    {
        public string Data { get; set; }

        public string Meta { get; set; }

        public string Composer { get; set; }

        public bool Searchable { get; set; }

        public bool Orderable { get; set; }

        public Search Search { get; set; }
    }
}