namespace NetCoreStack.Contracts
{
    public interface IEntityIdentity<TKey> : IEntity
    {
        TKey Id { get; set; }
    }
}
