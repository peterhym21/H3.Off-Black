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
    public class OrderController : ControllerBase
    {

        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }


        [HttpGet]
        [Route("/AllOrder")]
        public async Task<List<OrderDTO>> GetAll()
        {
            return await _orderService.GetAll();
        }

        [HttpGet]
        [Route("/LastOrder")]
        public async Task<OrderDTO> GetLastOrder()
        {
            return await _orderService.GetLastOrder();
        }

        [HttpPost]
        [Route("/CreateOrder")]
        public async Task Create()
        {
            OrderDTO order = new OrderDTO();
            await _orderService.Create(order);
        }

        [HttpPost]
        [Route("/CustomCreateOrder")]
        public async Task CustomCreate()
        {
            OrderDTO order = new OrderDTO();
            await _orderService.CustomCreate(order);
        }

        [HttpPut]
        [Route("/CustomUpdateOrder")]
        public async Task CustomUpdate()
        {
            OrderDTO order = new OrderDTO();
            await _orderService.CustomUpdate(order);
        }

        [HttpPut]
        [Route("/DeleteOrder")]
        public async Task Delete()
        {
            OrderDTO order = new OrderDTO();
            await _orderService.Delete(order);
        }

        [HttpPut]
        [Route("/SendEmail")]
        public async Task SendEmail()
        {
            OrderDTO order = new OrderDTO();
            await _orderService.SendEmail(order);
        }

        [HttpPut]
        [Route("/UpdateOrder")]
        public async Task Update()
        {
            OrderDTO order = new OrderDTO();
            await _orderService.Update(order);
        }
    }
}
