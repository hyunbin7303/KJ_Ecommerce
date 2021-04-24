using ECommerce.Core.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Core.Models
{
    public class Invoice : Entity<string>
    {
        public string OrderId { get; set; }
        public string CustomerId { get; set; }
        public string ShipmentId { get; set; }
        public string PaymentId { get; set; }
        public DateTimeOffset Date { get; set; }
        public decimal SubTotal { get; set; }
        public decimal? ShippingTotal { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Total { get; set; }
        public string CustomerNote { get; set; }

    }
}
