using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Domain.Models.OrderAggregate
{
    public class OrderDetails : Entity
    {
        public decimal UnitPrice { get; private set; }
        public int Units { get; private set; }
    }
}
