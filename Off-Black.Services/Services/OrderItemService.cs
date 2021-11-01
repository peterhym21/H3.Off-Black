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
    public class OrderItemService : GenericService<OrderItemDTO, IOrderItemRepository, OrderItem>, IOrderItemService
    {
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly MappingService _mappingService;
        public OrderItemService(IOrderItemRepository GenericRepository, MappingService mappingService) : base(GenericRepository, mappingService)
        {
            _orderItemRepository = GenericRepository;
            _mappingService = mappingService;
        }

        public async Task CustomCreate(OrderItemDTO orderItem)
        {
            try
            {
                await _orderItemRepository.CustomCreate(_mappingService._mapper.Map<OrderItem>(orderItem));
                LogInformation($"Successfully created a new {orderItem} ");
            }
            catch (Exception e)
            {
                LogError($"Failed to create a new {orderItem} ", e);
            }
        }

        public async Task<OrderItemDTO> GetLastOrderItem()
        {
            try
            {
                OrderItemDTO orderItem = _mappingService._mapper.Map<OrderItemDTO>(await _orderItemRepository.GetLastOrderItem());
                LogInformation($"Successfully fetched the Last Orderitem");
                return orderItem;
            }
            catch (Exception e)
            {
                LogError($"Failed to fetch the last Orderitem", e);
                return null;
            }
        }
    }
}
