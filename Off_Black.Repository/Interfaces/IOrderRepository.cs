using Off_Black.Repository.Entities;
using System.Threading.Tasks;

namespace Off_Black.Interfaces
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task CustomUpdate(Order order);
        Task CustomCreate(Order order);
        /// <summary>
        /// Get the Last OrderItem
        /// </summary>
        /// <returns></returns>
        Task<Order> GetLastOrder();
    }
}
