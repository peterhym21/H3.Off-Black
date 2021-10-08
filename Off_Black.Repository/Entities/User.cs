namespace Off_Black.Repository.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public int FK_CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}
