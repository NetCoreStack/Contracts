namespace NetCoreStack.Contracts
{
    public interface ICollectionModel<TKey> : IModelKey<TKey>
    {
        ObjectState ObjectState { get; set; }
    }
}
