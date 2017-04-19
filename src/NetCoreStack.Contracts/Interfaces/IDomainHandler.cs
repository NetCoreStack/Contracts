using System.Threading.Tasks;

namespace NetCoreStack.Contracts.Interfaces
{
    public interface IDomainHandler<T> where T : IDomainEvent
    {
        Task HandleAsync(T evnt);
    }
}