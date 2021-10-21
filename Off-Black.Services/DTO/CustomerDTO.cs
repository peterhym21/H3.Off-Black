using System.Collections.Generic;

namespace Off_Black.Services.DTO
{
    public class CustomerDTO
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public string ZipCode { get; set; }



        public ICollection<OrderDTO> Orders { get; set; }

        public int? FK_UserID { get; set; }
        public UserDTO User { get; set; }
    }
}
