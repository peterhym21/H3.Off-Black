using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Off_Black.Repository.Entities
{
    public class Order
    {
        public int OrderID { get; set; }
        public int TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }

        public int FK_CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}
