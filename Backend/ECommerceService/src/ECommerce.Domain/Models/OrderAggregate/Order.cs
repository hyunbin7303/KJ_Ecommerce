using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Domain.Models.OrderAggregate
{
    public partial class Order
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public string CartId { get; set; }
        public OrderStatus Status { get; set; }
        public string Comment { get; set; }
        public DateTimeOffset? RequiredDate { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public DateTimeOffset? UpdatedDate { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
