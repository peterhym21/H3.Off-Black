using Microsoft.AspNetCore.Mvc;
using Off_Black.Service.DTO;
using Off_Black.Service.Interfaces;
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
        [Route("All")]
        public async Task<List<OrderDTO>> GetAll()
        {
            return await _orderService.GetAll();
        }

        [HttpGet]
        [Route("LastOrder")]
        public async Task<OrderDTO> GetLastOrder()
        {
            return await _orderService.GetLastOrder();
        }

        [HttpPost]
        [Route("Create")]
        public async Task Create(OrderDTO order)
        {
            await _orderService.Create(order);
        }

        [HttpPost]
        [Route("CustomCreate")]
        public async Task CustomCreate(OrderDTO order)
        {
            await _orderService.CustomCreate(order);
        }

        [HttpPut]
        [Route("CustomUpdate")]
        public async Task CustomUpdate(OrderDTO order)
        {
            await _orderService.CustomUpdate(order);
        }

        [HttpPut]
        [Route("Delete")]
        public async Task Delete(OrderDTO order)
        {
            await _orderService.Delete(order);
        }

        [HttpPut]
        [Route("SendEmail")]
        public async Task SendEmail(OrderDTO order)
        {
            await _orderService.SendEmail(order);
        }

        [HttpPut]
        [Route("Update")]
        public async Task Update(OrderDTO order)
        {
            await _orderService.Update(order);
        }
    }
}
