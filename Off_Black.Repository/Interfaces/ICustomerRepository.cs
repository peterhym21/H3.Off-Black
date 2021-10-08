using Off_Black.Repository.Entities;
using System.Threading.Tasks;

namespace Off_Black.Interfaces
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        /// <summary>
        /// Get a singel customer from <param name="id"></param> in the Database
        /// </summary>
        /// <returns></returns>
        Task<Customer> GetById(int id);
    }
}
