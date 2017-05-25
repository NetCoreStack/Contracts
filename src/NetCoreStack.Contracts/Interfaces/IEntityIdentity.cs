namespace NetCoreStack.Contracts
{
    public interface IEntityIdentity<TKey> : IEntity, IModelKey<TKey>
    {
    }
}
