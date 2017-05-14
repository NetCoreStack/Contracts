namespace NetCoreStack.Contracts
{
    public interface ICollectionModel<TKey>
    {
        TKey Id { get; set; }
        ObjectState ObjectState { get; set; }
    }
}
