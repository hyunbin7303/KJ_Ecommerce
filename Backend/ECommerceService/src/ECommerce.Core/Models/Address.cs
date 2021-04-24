using ECommerce.Core.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Core.Models
{
    public class Address : Entity<int>
    {
        public Address(int id, string contactname, string phone, string address1, string city, string province, string country, string address2 = null, string desc = null)
        {
            Id = id;
            ContactName = contactname;
            Phone = phone;
            Address1 = address1;
            Address2 = address2;
            City = city;
            Province = province;
            Country = country;
            Description = desc;
        }
        public string ContactName { get; }
        public string Phone { get; }
        public string Address1 { get;  }
        public string? Address2 { get;  }
        public string City { get;  }
        public string Province { get;  }
        public string Country { get;  }
        public string Description { get;  }
    }
}
