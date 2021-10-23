using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Query.Vendor
{
    public class VendorCreateDTO
    {
        public string VendorName { get; set; }
        public string DisplayName { get; set; }
        public string DomainUser { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }

    }
}
