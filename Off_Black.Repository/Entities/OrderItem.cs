namespace Off_Black.Repository.Entities
{
    public class OrderItem
    {
        public int OrderItmeID { get; set; }
        public int Amount { get; set; }

        public int FK_OrderID { get; set; }
        public Order Order { get; set; }
        public int FK_ProductID { get; set;  }
        public Product Product { get; set; }
    }
}
