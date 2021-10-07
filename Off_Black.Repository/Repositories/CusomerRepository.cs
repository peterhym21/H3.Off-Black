using Microsoft.EntityFrameworkCore;
using Off_Black.DB;
using Off_Black.Interfaces;
using Off_Black.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Off_Black.Repositories
{
    public class CusomerRepository : GenericRepository<Customer>, ICusomerRepository
    {
        private readonly OffBlackContext _dbContext;
        public CusomerRepository(OffBlackContext offBlackContext) : base(offBlackContext)
        {
            _dbContext = offBlackContext;
        }

        public async Task<Product> GetOneProduct(int id)
        {
            return await _dbContext.Products.SingleOrDefaultAsync(x => x.ProductID == id);

        }

    }
}
