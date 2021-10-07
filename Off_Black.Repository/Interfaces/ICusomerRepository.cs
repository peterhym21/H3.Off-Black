using Off_Black.Repository.Entities;
using System.Threading.Tasks;

namespace Off_Black.Interfaces
{
    public interface ICusomerRepository : IGenericRepository<Customer>
    {
        /// <summary>
        /// Get a singel product from <param name="id"></param> in the Database
        /// </summary>
        /// <returns></returns>
        Task<Product> GetById(int id);
    }
}
