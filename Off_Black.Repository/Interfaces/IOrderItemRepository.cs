using Off_Black.Repository.Entities;
using System.Threading.Tasks;

namespace Off_Black.Interfaces
{
    public interface IOrderItemRepository : IGenericRepository<OrderItem>
    {
        /// <summary>
        /// Get the Last OrderItem
        /// </summary>
        /// <returns></returns>
        Task<OrderItem> GetLastOrderItem();
    }
}
