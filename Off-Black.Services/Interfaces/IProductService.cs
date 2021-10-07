using Off_Black.Services.DTO;
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
    }
}
