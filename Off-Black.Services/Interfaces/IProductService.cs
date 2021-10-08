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
        Task<List<ProductDTO>> GetAllSortetPrice();

    }
}
