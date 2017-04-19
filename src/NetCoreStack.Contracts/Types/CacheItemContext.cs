namespace NetCoreStack.Contracts
{
    public class CacheItemContext
    {
        public string Key { get; }
        public object Value { get; set; }
        public CacheItemDescriptor Descriptor { get; set; }

        public CacheItemContext(string key)
        {
            Key = key;
        }
    }
}