namespace NetCoreStack.Contracts
{
    public class BaseCompositeType : IQueryableObject<long>
    {
        public long Id { get; set; }
    }
}