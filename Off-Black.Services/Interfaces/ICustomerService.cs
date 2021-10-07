using Off_Black.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Off_Black.Services.Interfaces
{
    public interface ICustomerService : IGenericService<CustomerDTO>
    {
        /// <summary>
        /// Get a singel product from <param name="id"></param> in the Database
        /// </summary>
        /// <returns></returns>
        Task<CustomerDTO> GetById(int id);
    }
}
