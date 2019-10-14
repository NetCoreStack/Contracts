namespace NetCoreStack.Contracts
{
    public interface IModel<TKey>
    {
        TKey Id { get; set; }
    }
}
