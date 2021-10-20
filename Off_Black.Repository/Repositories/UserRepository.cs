using Microsoft.EntityFrameworkCore;
using Off_Black.DB;
using Off_Black.Interfaces;
using Off_Black.Repository.Entities;
using System.Threading.Tasks;

namespace Off_Black.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly OffBlackContext _dbContext;
        public UserRepository(OffBlackContext offBlackContext) : base(offBlackContext)
        {
            _dbContext = offBlackContext;
        }

        public async Task<User> GetById(int id)
        {
            return await _dbContext.Users.AsNoTracking().SingleOrDefaultAsync(x => x.UserID == id);

        }

    }
}
