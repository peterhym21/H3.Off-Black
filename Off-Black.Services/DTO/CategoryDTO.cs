using System.Collections.Generic;

namespace Off_Black.Service.DTO
{
    public class CategoryDTO
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string CategoryImage1 { get; set; }
        public string CategoryImage2 { get; set; }

        public ICollection<ProductDTO> Products { get; set; }
    }
}
