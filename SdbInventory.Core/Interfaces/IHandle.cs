using System.Text;
using System.Threading.Tasks;

namespace SdbInventory.Core.Interfaces
{
    public interface IHandle<in T> where T : BaseDomainEvent
    {
        Task Handle(T domainEvent);
    }
}
