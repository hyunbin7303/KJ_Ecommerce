using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerce.Domain.Models.OrderAggregate
{
    public class Address
    {
        [StringLength(100)]
        public string Street { get; private set; }
        [StringLength(100)]
        public string Street2 { get; private set; } = "";

        [StringLength(50)]
        public string City { get; private set; }
        [StringLength(50)]
        public string State { get; private set; }
        [StringLength(50)]
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
        public Address() { }
        public Address(string street, string city, string state, string country, string zipcode)
        {
            Street = street;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipcode;
        }
    }
}
