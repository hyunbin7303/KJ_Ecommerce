﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Domain.Models.OrderAggregate
{
    public class Order
    {
        public Order()
        {
            OrderItems = new List<OrderItem>();
        }
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public int? VendorId { get; set; }
        public string CartId { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public DateTimeOffset? RequiredDate { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public DateTimeOffset? UpdatedDate { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
