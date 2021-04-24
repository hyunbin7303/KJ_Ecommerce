using ECommerce.Core.Models.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Query
{
    public class OrderResponse : BaseResponse<Order>
    {
        public OrderResponse(Order product) : base(product) { }

        public OrderResponse(string message) : base(message) { }
    }
}
