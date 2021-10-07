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
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly OffBlackContext _dbContext;
        public ProductRepository(OffBlackContext offBlackContext) : base(offBlackContext)
        {
            _dbContext = offBlackContext;
        }

        public async Task<Product> GetOneProduct(int id)
        {
            return await _dbContext.Products.SingleAsync(x => x.ProductID == id);

        }
    }
}
