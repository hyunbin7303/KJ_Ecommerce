using ECommerce.Core.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Core.Models
{
    public class Customer : Entity<string>
    {
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public string CustomerName { get; set; }
        public string Description { get; set; }
    }
}
