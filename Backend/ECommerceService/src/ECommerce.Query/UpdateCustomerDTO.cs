using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Query
{
    public class UpdateCustomerDTO
    {
        public string UserName { get; set; }
        public string Phone { get; }
        public string Address1 { get; }
        public string? Address2 { get; }
        public string City { get; }
        public string Province { get; }
        public string Country { get; }
        public string? Description { get; }
        public int VendorId { get; set; }
        public string CustomerName { get; set; }
    }
}
