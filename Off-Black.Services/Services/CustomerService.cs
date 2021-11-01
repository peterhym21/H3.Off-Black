using Off_Black.Interfaces;
using Off_Black.Repository.Entities;
using Off_Black.Service.DTO;
using Off_Black.Service.Interfaces;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Off_Black.Service.Services
{
    public class CustomerService : GenericService<CustomerDTO, ICustomerRepository, Customer>, ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly MappingService _mappingService;
        public CustomerService(ICustomerRepository GenericRepository, MappingService mappingService) : base(GenericRepository, mappingService)
        {
            _customerRepository = GenericRepository;
            _mappingService = mappingService;
        }

        public async Task<CustomerDTO> GetById(int id)
        {
            if (id == 0)
            {
                LogInformation($"Skipped fecthing the site because siteId was 0");
                return null;
            }
            try
            {
                CustomerDTO customer = _mappingService._mapper.Map<CustomerDTO>(await _customerRepository.GetById(id));
                LogInformation($"Successfully fetched the site with the id: ({id})");
                return customer;
            }
            catch (Exception e)
            {
                LogError($"Failed to fetch the site with the id: ({id})", e);
                return null;
            }
        }

        public async Task<CustomerDTO> GetLastCustomer()
        {
            try
            {
                CustomerDTO customer = _mappingService._mapper.Map<CustomerDTO>(await _customerRepository.GetLastCustomer());
                LogInformation($"Successfully fetched the last Customer)");
                return customer;
            }
            catch (Exception e)
            {
                LogError($"Failed to fetch the last customer)", e);
                return null;
            }
        }
    }
}
