namespace NetCoreStack.Contracts
{
    public interface IEntityIdentity<TKey> : IEntity, IModel<TKey>
    {
    }
}
