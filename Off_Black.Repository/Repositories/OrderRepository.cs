using Microsoft.EntityFrameworkCore;
using Off_Black.DB;
using Off_Black.Interfaces;
using Off_Black.Repository.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Off_Black.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        private readonly OffBlackContext _dbContext;
        public OrderRepository(OffBlackContext offBlackContext) : base(offBlackContext)
        {
            _dbContext = offBlackContext;
        }
        /// <summary>
        /// Get the Last OrderItem
        /// </summary>
        /// <returns></returns>
        public async Task<Order> GetLastOrder()
        {
            return await _dbContext.Orders.OrderBy(x => x.OrderID).Include(y => y.OrderItems).ThenInclude(z => z.Product).Include(o => o.Customer).LastOrDefaultAsync();
        }

        public async Task CustomCreate(Order order)
        {
            foreach (var item in order.OrderItems)
            {
                _dbContext.Attach(item);
            }
            
            _dbContext.Add(order);
            await _dbContext.SaveChangesAsync();
        }

        public async Task CustomUpdate(Order order)
        {
            _dbContext.Entry(order).State = EntityState.Added;
            _dbContext.Entry(order.OrderItems).State = EntityState.Added;
            await _dbContext.SaveChangesAsync();
        }
    }
}
