using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Domain.Models.OrderAggregate
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        //public OrderStatus OrderStatus { get; set; }
    }
}
