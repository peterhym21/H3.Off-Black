using Off_Black.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Off_Black.Service.Interfaces
{
    public interface IOrderService : IGenericService<OrderDTO>
    {
        Task CustomUpdate(OrderDTO order);
        Task CustomCreate(OrderDTO order);
        /// <summary>
        /// Get the Last OrderItem
        /// </summary>
        /// <returns></returns>
        Task<OrderDTO> GetLastOrder();

        Task SendEmail(OrderDTO order);

    }
}
