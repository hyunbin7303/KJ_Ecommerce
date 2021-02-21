using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Domain.Models.OrderAggregate
{
    public class Order : Entity
    {
        public string CustomerId { get; set; }
        //public OrderStatus OrderStatus { get; set; }
        public Order(){}
        public string BuyerId { get; private set; }
        public DateTimeOffset OrderDate { get; private set; } = DateTimeOffset.Now;
        public Address ShipToAddress { get; private set; }
        private readonly List<OrderItem> _orderItems = new List<OrderItem>();
        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems.AsReadOnly();
    }
}
