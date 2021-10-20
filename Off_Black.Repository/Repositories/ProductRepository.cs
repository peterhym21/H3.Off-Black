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

        #region Get Men

        public async Task<List<Product>> GetAllMen()
        {
            return await _dbContext.Products.Where(x => x.Gender == false).AsNoTracking().ToListAsync();
        }

        public async Task<List<Product>> GetAllMenByCategory(int Id)
        {
            return await _dbContext.Products.Where(x => x.Gender == false && x.FK_CategoryID == Id).AsNoTracking().ToListAsync();
        }

        public async Task<List<Product>> GetPaginatedResultMen(int currentPage, int pageSize = 10)
        {
            var data = await GetAllMen();
            return data.OrderBy(d => d.ProductID).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }

        #endregion

        #region Get Woman
        public async Task<List<Product>> GetAllWoman()
        {
            return await _dbContext.Products.Where(x => x.Gender == true).AsNoTracking().ToListAsync();
        }

        public async Task<List<Product>> GetAllWomanByCategory(int Id)
        {
            return await _dbContext.Products.Where(x => x.Gender == true && x.FK_CategoryID == Id).AsNoTracking().ToListAsync();
        }

        public async Task<List<Product>> GetPaginatedResultWoman(int currentPage, int pageSize = 10)
        {
            var data = await GetAllWoman();
            return data.OrderBy(d => d.ProductID).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }

        #endregion

        public async Task<List<Product>> GetAllSortetPriceASC()
        {
            return await _dbContext.Products.OrderBy(x => x.Price).AsNoTracking().ToListAsync();
        }

        public async Task<List<Product>> GetAllSortetPriceDESC()
        {
            return await _dbContext.Products.OrderByDescending(x => x.Price).AsNoTracking().ToListAsync();
        }

        public async Task<List<Product>> GetAllByCategory(int Id)
        {
            return await _dbContext.Products.Where(x => x.FK_CategoryID == Id).AsNoTracking().ToListAsync();
        }


        public async Task<Product> GetById(int id)
        {
            return await _dbContext.Products.AsNoTracking().SingleOrDefaultAsync(x => x.ProductID == id);

        }

        public async Task<List<Product>> GetAllByAllFilters(string searchterm, int currentPage, int pageSize = 10)
        {
            var data = await GetAllBySeachTearm(searchterm);
            return data.OrderBy(d => d.ProductID).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }

        public async Task<List<Product>> GetAllBySeachTearm(string searchterm)
        {
            return await _dbContext.Products.Where(x => x.ProductName.Contains(searchterm)).AsNoTracking().ToListAsync();
        }

    }
}
