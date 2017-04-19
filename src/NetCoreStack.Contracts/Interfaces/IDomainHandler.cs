using System.Threading.Tasks;

namespace NetCoreStack.Contracts
{
    public interface IDomainHandler<T> where T : IDomainEvent
    {
        Task HandleAsync(T evnt);
    }
}