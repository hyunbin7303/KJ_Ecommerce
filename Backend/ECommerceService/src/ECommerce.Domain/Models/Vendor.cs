﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Domain.Models
{
    public partial class Vendor
    {
        public Vendor()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string VendorName { get; set; }
        public int? AddressId { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public byte[] LastUpdatedtime { get; set; }
        public string Note { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
