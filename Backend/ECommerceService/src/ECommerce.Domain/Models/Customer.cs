using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Domain.Models
{
    public partial class Customer
    {
        public string Id { get; set; }
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public string CustomerName { get; set; }
        public string Description { get; set; }
    }
}
