using ECommerce.Core.Models.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Interfaces
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<Order> GetOrderById(string orderId);
        Task<IEnumerable<Order>> GetOrdersByCustomerId(string customerId);
        Task<IEnumerable<Order>> GetOrdersByVendorId(string vendorId);
        Task<Order> GetOrderByCartId(string cartId);
        Task<IEnumerable<Order>> GetAllOrdersByTime(DateTimeOffset? startTime, DateTimeOffset? endTime);
        Task<OrderItem> GetOrderItems(string orderId);
        Task<IEnumerable<OrderItem>> GetllOrderItemsByOrderId(string orderId);
    }
}
