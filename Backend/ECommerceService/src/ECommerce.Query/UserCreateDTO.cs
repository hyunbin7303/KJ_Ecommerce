using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Query
{
    public class UserCreateDTO
    {
        public string Account { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string? PhoneNumber { get; set; }
        public int VendorId { get; set; }
    }
}
