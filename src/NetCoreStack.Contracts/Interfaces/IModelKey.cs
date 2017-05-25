namespace NetCoreStack.Contracts
{
    public interface IModelKey<TKey>
    {
        TKey Id { get; set; }
    }
}
