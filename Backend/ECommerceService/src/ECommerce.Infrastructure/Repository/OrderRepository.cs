using ECommerce.Domain.Models.OrderAggregate;
using ECommerce.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Repository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(MainEcommerceDBContext context) : base(context)
        {
        }






    }
}
