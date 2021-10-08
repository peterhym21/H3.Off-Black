namespace Off_Black.Services.DTO
{
    public class UserDTO
    {
        public int UserID { get; set; }
        public int FK_CustomerID { get; set; }
        public CustomerDTO Customer { get; set; }
    }
}
