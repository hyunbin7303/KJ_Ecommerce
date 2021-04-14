using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Domain.Models.OrderAggregate
{
    public class OrderDetails : Entity
    {
        public string OrderId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get;  set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
    }
}
