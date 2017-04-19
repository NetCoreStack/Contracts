using System.Threading.Tasks;

namespace NetCoreStack.Contracts
{
    public interface IEventDispatcher
    {
        Task Dispatch<TEvent>(TEvent eventToDispatch) where TEvent : IDomainEvent;
    }
}