using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Domain.Models.OrderAggregate
{
    public class OrderItem : Entity
    {
        //public CatalogItemOrdered ItemOrdered { get; private set; }
        public decimal UnitPrice { get; private set; }
        public int Units { get; private set; }
    }
}
