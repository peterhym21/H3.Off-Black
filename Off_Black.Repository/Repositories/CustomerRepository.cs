using Microsoft.EntityFrameworkCore;
using Off_Black.DB;
using Off_Black.Interfaces;
using Off_Black.Repository.Entities;
using System.Threading.Tasks;

namespace Off_Black.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        private readonly OffBlackContext _dbContext;
        public CustomerRepository(OffBlackContext offBlackContext) : base(offBlackContext)
        {
            _dbContext = offBlackContext;
        }

        public async Task<Customer> GetById(int id)
        {
            return await _dbContext.Customers.SingleOrDefaultAsync(x => x.CustomerID == id);

        }

    }
}
