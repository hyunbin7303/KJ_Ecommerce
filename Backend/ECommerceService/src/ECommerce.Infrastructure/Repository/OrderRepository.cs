﻿using ECommerce.Core.Interfaces;
using ECommerce.Core.Models;
using ECommerce.Core.Models.OrderAggregate;
using ECommerce.Infrastructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Repository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(MainEcommerceDBContext context) : base(context)
        {
        }
        public Task ChangeQuantity(string orderItem, decimal quantity)
        {
            throw new NotImplementedException();
        }
        public override IEnumerable<Order> Get(Expression<Func<Order, bool>> filter = null, Func<IQueryable<Order>, IOrderedQueryable<Order>> orderBy = null, string includeProperties = "", CancellationToken cancellationToken=default)
        {
            return base.Get(filter, orderBy, includeProperties);
        }
        public Task<IEnumerable<Order>> GetAllOrdersByTime(DateTimeOffset? startTime, DateTimeOffset? endTime)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<OrderItem>> GetAllOrderItemsByOrderId(string orderId)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrderByCartId(string cartId)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrderById(string orderId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetOrdersByCustomerId(string customerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetOrdersByVendorId(string vendorId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveOrderItem(string orderId, string orderItem)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderItem>> GetOrderItems(string orderId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetActiveOrdersAssignedToCustomer(Customer id)
        {
            return base.GetAll()
                    .Where(order => order.CustomerId == id.Id)
                    .Where(order => order.Status != OrderStatus.Closed)
                    .ToArray();
        }
    }
}
