using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerce.Domain.Models.OrderAggregate
{
    public class Order : Entity
    {
        [Key]
        [Column("order_id")]
        public string orderId { get; set; }
        public string CustomerId { get; set; }
        public string BuyerId { get; private set; }
        public string OrderCreatedBy { get; set; }
        public DateTimeOffset OrderDate { get; private set; } = DateTimeOffset.Now;
        public DateTimeOffset OrderUpdateDate { get; private set; } = DateTimeOffset.Now;
        public Address ShipToAddress => new Address();
        public decimal OrderTotal { get; set; }
        public decimal OrderSubTotal { get; set; }
        public decimal TotalTax { get; set; }
        public OrderStatus OrderStatus { get; set; }
        private readonly List<OrderDetails> _orderItems = new List<OrderDetails>();
        public IReadOnlyCollection<OrderDetails> OrderItems => _orderItems.AsReadOnly();
    }
}
