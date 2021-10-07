using Off_Black.DB;
using Off_Black.Interfaces;
using Off_Black.Repository.Entities;

namespace Off_Black.Repositories
{
    public class OrderItemRepository : GenericRepository<OrderItem>, IOrderItemRepository
    {
        private readonly OffBlackContext _dbContext;
        public OrderItemRepository(OffBlackContext offBlackContext) : base(offBlackContext)
        {
            _dbContext = offBlackContext;
        }
    }
}
