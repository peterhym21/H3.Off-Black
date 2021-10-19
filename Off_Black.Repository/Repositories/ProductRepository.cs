using Microsoft.EntityFrameworkCore;
using Off_Black.DB;
using Off_Black.Interfaces;
using Off_Black.Repository.Entities;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<List<Product>> GetAllMen()
        {
            return await _dbContext.Products.Where(x => x.Gender == false).ToListAsync();
        }

        public async Task<List<Product>> GetAllMenByCategory(int Id)
        {
            return await _dbContext.Products.Where(x => x.Gender == false && x.FK_CategoryID == Id).ToListAsync();
        }

        public async Task<List<Product>> GetAllWoman()
        {
            return await _dbContext.Products.Where(x => x.Gender == true).ToListAsync();
        }

        public async Task<List<Product>> GetAllWomanByCategory(int Id)
        {
            return await _dbContext.Products.Where(x => x.Gender == true && x.FK_CategoryID == Id).ToListAsync();
        }

        public async Task<List<Product>> GetAllSortetPrice()
        {
            return await _dbContext.Products.OrderBy(x => x.Price).ToListAsync();
        }
        public async Task<List<Product>> GetAllByCategory(int Id)
        {
            return await _dbContext.Products.Where(x => x.FK_CategoryID == Id).ToListAsync();
        }


        public async Task<Product> GetById(int id)
        {
            return await _dbContext.Products.SingleOrDefaultAsync(x => x.ProductID == id);

        }


        public async Task<List<Product>> GetPaginatedResultMen(int currentPage, int pageSize = 10)
        {
            var data = await GetAllMen();
            return data.OrderBy(d => d.ProductID).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }
        public async Task<List<Product>> GetPaginatedResultWoman(int currentPage, int pageSize = 10)
        {
            var data = await GetAllWoman();
            return data.OrderBy(d => d.ProductID).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }

        public async Task<List<Product>> GetAllBySeachTearm(string seachtearm)
        {
            return await _dbContext.Products.Where(x => x.ProductName.Contains(seachtearm)).ToListAsync();
        }

    }
}
