using System.Threading.Tasks;

namespace NetCoreStack.Contracts.Interfaces
{
    public interface IEventDispatcher
    {
        Task Dispatch<TEvent>(TEvent eventToDispatch) where TEvent : IDomainEvent;
    }
}