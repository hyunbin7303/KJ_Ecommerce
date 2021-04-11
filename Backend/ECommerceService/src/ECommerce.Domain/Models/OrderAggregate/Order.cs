using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Infrastructure.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public string Id { get; set; }
        public string CustomerId { get; set; }
        public string CartId { get; set; }
        public string Status { get; set; }
        public DateTime? RequiredDate { get; set; }
        public string Comment { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
