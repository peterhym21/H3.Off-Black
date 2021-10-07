using Off_Black.DB;
using Off_Black.Interfaces;
using Off_Black.Repository.Entities;

namespace Off_Black.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly OffBlackContext _dbContext;
        public CategoryRepository(OffBlackContext offBlackContext) : base(offBlackContext)
        {
            _dbContext = offBlackContext;
        }

    }
}
