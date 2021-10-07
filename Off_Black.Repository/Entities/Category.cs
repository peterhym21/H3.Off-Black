using System.Collections.Generic;

namespace Off_Black.Repository.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
        
    }
}
