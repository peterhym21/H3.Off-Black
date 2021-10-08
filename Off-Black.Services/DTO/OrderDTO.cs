using System;
using System.Collections.Generic;

namespace Off_Black.Services.DTO
{
    public class OrderDTO
    {
        public int OrderID { get; set; }
        public int TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public ICollection<OrderItemDTO> OrderItems { get; set; }

        public int FK_CustomerID { get; set; }
        public CustomerDTO Customer { get; set; }
    }
}
