using System.Threading.Tasks;

namespace SdbInventory.Core.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task Dispatch(BaseDomainEvent domainEvent);
    }
}
