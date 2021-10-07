using Off_Black.DB;
using Off_Black.Interfaces;
using Off_Black.Repository.Entities;

namespace Off_Black.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        private readonly OffBlackContext _dbContext;
        public OrderRepository(OffBlackContext offBlackContext) : base(offBlackContext)
        {
            _dbContext = offBlackContext;
        }



    }
}
