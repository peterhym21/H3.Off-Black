using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Off_Black.Repository.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public int FK_CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}
