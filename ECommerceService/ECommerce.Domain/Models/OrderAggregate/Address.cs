using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Domain.Models.OrderAggregate
{
    public class Address
    {
        public string Street { get; private set; }
        public string Street2 { get; private set; } = "";
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
        private Address() { }
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
