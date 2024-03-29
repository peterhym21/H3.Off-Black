﻿using Off_Black.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Off_Black.Service.Interfaces
{
    public interface ICustomerService : IGenericService<CustomerDTO>
    {
        /// <summary>
        /// Get a singel product from <param name="id"></param> in the Database
        /// </summary>
        /// <returns></returns>
        Task<CustomerDTO> GetById(int id);

        /// <summary>
        /// Get last custoerm created
        /// </summary>
        /// <returns></returns>
        Task<CustomerDTO> GetLastCustomer();
    }
}
