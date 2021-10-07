using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Off_Black.Repository.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImagePath { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }

        public int FK_CategoryID { get; set; }
        public Category Catagory { get; set; }

    }
}
