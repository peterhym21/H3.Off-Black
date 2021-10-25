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
    public class OrderItemController : ControllerBase
    {

        private readonly IOrderItemService _orderItemService;

        public OrderItemController(IOrderItemService orderItemService)
        {
            _orderItemService = orderItemService;
        }

        [HttpGet]
        [Route("/AllOrderItem")]
        public async Task<List<OrderItemDTO>> GetAll()
        {
            return await _orderItemService.GetAll();
        }

        [HttpGet]
        [Route("/LastOrderItem")]
        public async Task<OrderItemDTO> GetLastOrderItem()
        {
            return await _orderItemService.GetLastOrderItem();
        }

        [HttpPost]
        [Route("/CreateOrderItem")]
        public async Task Create()
        {
            OrderItemDTO orderItem = new OrderItemDTO();
            await _orderItemService.Create(orderItem);
        }

        [HttpPost]
        [Route("/CustomCreateOrderItem")]
        public async Task CustomCreate()
        {
            OrderItemDTO orderItem = new OrderItemDTO();
            await _orderItemService.CustomCreate(orderItem);
        }

        [HttpPut]
        [Route("/DeleteOrderItem")]
        public async Task Delete()
        {
            OrderItemDTO orderItem = new OrderItemDTO();
            await _orderItemService.Delete(orderItem);
        }

        [HttpPut]
        [Route("/UpdateOrderItem")]
        public async Task Update()
        {
            OrderItemDTO orderItem = new OrderItemDTO();
            await _orderItemService.Update(orderItem);
        }
    }
}
