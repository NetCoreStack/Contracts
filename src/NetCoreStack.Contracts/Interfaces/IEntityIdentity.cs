namespace NetCoreStack.Contracts
{
    public interface IEntityIdentity<TKey> : IObjectState
    {
        TKey Id { get; set; }
    }
}
