using Microsoft.AspNetCore.Mvc;
using Off_Black.Services.DTO;
using Off_Black.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Off_Black.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("/AllCustomer")]
        public async Task<List<CustomerDTO>> GetAll()
        {
            return await _customerService.GetAll();
        }

        [HttpGet]
        [Route("/ByIdCustomer")]
        public async Task<CustomerDTO> GetById()
        {
            return await _customerService.GetById(2);
        }

        [HttpGet]
        [Route("/LastCustomer")]
        public async Task<CustomerDTO> GetLastCustomer()
        {
            return await _customerService.GetLastCustomer();
        }

        [HttpPost]
        [Route("/CreateCustomer")]
        public async Task Create()
        {
            CustomerDTO customer = new CustomerDTO();
            await _customerService.Create(customer);
        }

        [HttpPut]
        [Route("/DeleteCustomer")]
        public async Task Delete()
        {
            CustomerDTO customer = new CustomerDTO();
            await _customerService.Create(customer);
        }

        [HttpPut]
        [Route("/UpdateCustomer")]
        public async Task Update()
        {
            CustomerDTO customer = new CustomerDTO();
            await _customerService.Create(customer);
        }
    }
}
