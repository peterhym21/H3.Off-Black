using Off_Black.Interfaces;
using Off_Black.Repository.Entities;
using Off_Black.Services.DTO;
using Off_Black.Services.Interfaces;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Off_Black.Services.Services
{
    public class OrderService : GenericService<OrderDTO, IOrderRepository, Order>, IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly MappingService _mappingService;
        public OrderService(IOrderRepository GenericRepository, MappingService mappingService) : base(GenericRepository, mappingService)
        {
            _orderRepository = GenericRepository;
            _mappingService = mappingService;
        }
    }
}
