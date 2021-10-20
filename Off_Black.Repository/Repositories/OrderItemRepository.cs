using Microsoft.EntityFrameworkCore;
using Off_Black.DB;
using Off_Black.Interfaces;
using Off_Black.Repository.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Off_Black.Repositories
{
    public class OrderItemRepository : GenericRepository<OrderItem>, IOrderItemRepository
    {
        private readonly OffBlackContext _dbContext;
        public OrderItemRepository(OffBlackContext offBlackContext) : base(offBlackContext)
        {
            _dbContext = offBlackContext;
        }

        public async Task<OrderItem> GetLastOrderItem()
        {
            return await _dbContext.OrderItems.OrderBy(x => x.OrderItmeID).AsNoTracking().LastOrDefaultAsync();
        }
    }
}
