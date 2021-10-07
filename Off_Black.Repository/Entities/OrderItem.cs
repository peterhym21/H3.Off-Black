using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Off_Black.Repository.Entities
{
    public class OrderItem
    {
        public int OrderItmeID { get; set; }
        public int Amount { get; set; }

        public int FK_ProductID { get; set;  }
        public Product Product { get; set; }
    }
}
