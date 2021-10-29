namespace Off_Black.Service.DTO
{
    public class ProductDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImagePath { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        /// <summary>
        /// If bool = true = womman
        /// if bool = false = men
        /// </summary>
        public bool Gender { get; set; }

        public int FK_CategoryID { get; set; }
        public CategoryDTO Catagory { get; set; }
    }
}
