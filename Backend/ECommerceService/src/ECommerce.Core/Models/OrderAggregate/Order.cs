using ECommerce.Core.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Core.Models.OrderAggregate
{
    public class Order : Entity<string>
    {
        public Order()
        {
            OrderItems = new List<OrderItem>();
        }
        public string CustomerId { get; set; }
        public int? VendorId { get; set; }
        public string CartId { get; set; }
        public OrderStatus Status { get; set; }
        public string Comment { get; set; }
        public DateTimeOffset? RequiredDate { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public DateTimeOffset? UpdatedDate { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

        //public DateTimeOffset CalculateExpirationDate()
        //{

        //}
    }
}
