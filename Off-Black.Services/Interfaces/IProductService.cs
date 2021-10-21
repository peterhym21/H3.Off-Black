using Off_Black.Services.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Off_Black.Services.Interfaces
{
    public interface IProductService : IGenericService<ProductDTO>
    {
        /// <summary>
        /// Get a singel product from <param name="id"></param> in the Database
        /// </summary>
        /// <returns></returns>
        Task<ProductDTO> GetById(int id);

        /// <summary>
        /// Get product in the Database sortet by price
        /// </summary>
        /// <returns></returns>
        Task<List<ProductDTO>> GetAllSortetPriceASC();
        /// <summary>
        /// Get product in the Database sortet by price
        /// </summary>
        /// <returns></returns>
        Task<List<ProductDTO>> GetAllSortetPriceDESC();

        /// <summary>
        /// Get product in the Database Where Gender = ture
        /// </summary>
        /// <returns></returns>
        Task<List<ProductDTO>> GetAllWoman();


        /// <summary>
        /// Get product in the Database Where Gender = false
        /// </summary>
        /// <returns></returns>
        Task<List<ProductDTO>> GetAllMen();

        /// <summary>
        /// Get product in the Database Where Gender = false And Category = Id
        /// </summary>
        /// <returns></returns>
        Task<List<ProductDTO>> GetAllMenByCategory(int Id);


        /// <summary>
        /// Get product in the Database Where Gender = ture And Category = Id
        /// </summary>
        /// <returns></returns>
        Task<List<ProductDTO>> GetAllWomanByCategory(int Id);

        /// <summary>
        /// Get product in the Database Where Category = Id
        /// </summary>
        /// <returns></returns>
        Task<List<ProductDTO>> GetAllByCategory(int Id);

        /// <summary>
        /// Paging for alle cloth category
        /// </summary>
        /// <param name="currentPage"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<List<ProductDTO>> GetPaginatedResultMen(int currentPage, int pageSize = 10);
        Task<List<ProductDTO>> GetPaginatedResultWoman(int currentPage, int pageSize = 10);

        /// <summary>
        /// get number of products
        /// </summary>
        /// <returns></returns>
        Task<int> GetCountMen();
        Task<int> GetCountWoman();
        Task<int> GetCountAll(string searchterm);

        /// <summary>
        /// Get Products by Seachtearm
        /// </summary>
        /// <param name="searchterm"></param>
        /// <returns></returns>
        Task<List<ProductDTO>> GetAllBySeachTearm(string searchterm);

        /// <summary>
        /// Get all products with all seachtarms for men and woman
        /// </summary>
        /// <param name="searchterm"></param>
        /// <param name="currentPage"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<List<ProductDTO>> GetAllByAllFilters(string searchterm, int currentPage, int pageSize = 10);

    }
}
