namespace Off_Black.Services.DTO
{
    public class OrderItemDTO
    {
        public int OrderItmeID { get; set; }
        public int Amount { get; set; }

        public int FK_ProductID { get; set; }
        public ProductDTO Product { get; set; }
    }
}
