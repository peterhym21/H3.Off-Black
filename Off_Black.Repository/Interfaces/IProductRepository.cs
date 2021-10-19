using Off_Black.Repository.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Off_Black.Interfaces
{
    public interface IProductRepository :  IGenericRepository<Product>
    {
        /// <summary>
        /// Get a singel product from <param name="id"></param> in the Database
        /// </summary>
        /// <returns></returns>
        Task<Product> GetById(int id);

        /// <summary>
        /// Get product in the Database sortet by price
        /// </summary>
        /// <returns></returns>
        Task<List<Product>> GetAllSortetPrice();

        /// <summary>
        /// Get product in the Database Where Gender = ture
        /// </summary>
        /// <returns></returns>
        Task<List<Product>> GetAllWoman();


        /// <summary>
        /// Get product in the Database Where Gender = false
        /// </summary>
        /// <returns></returns>
        Task<List<Product>> GetAllMen();

        /// <summary>
        /// Get product in the Database Where Gender = false And Category = Id
        /// </summary>
        /// <returns></returns>
        Task<List<Product>> GetAllMenByCategory(int Id);


        /// <summary>
        /// Get product in the Database Where Gender = ture And Category = Id
        /// </summary>
        /// <returns></returns>
        Task<List<Product>> GetAllWomanByCategory(int Id);

        /// <summary>
        /// Get product in the Database Where Category = Id
        /// </summary>
        /// <returns></returns>
        Task<List<Product>> GetAllByCategory(int Id);

    }
}
