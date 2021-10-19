﻿
using Off_Black.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Off_Black.Services.Interfaces
{
    public interface IOrderItemService : IGenericService<OrderItemDTO>
    {
        /// <summary>
        /// Get the Last OrderItem
        /// </summary>
        /// <returns></returns>
        Task<OrderItemDTO> GetLastOrderItem();
    }
}
