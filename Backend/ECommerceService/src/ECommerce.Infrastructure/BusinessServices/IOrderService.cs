using ECommerce.Domain.Models;
using ECommerce.Domain.Models.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.BusinessServices
{
    public interface IOrderService
    {
        Task CancelOrder(string orderId);
        Task<Order> CheckoutCart(string cartId);
        Task InvoiceOrder(string orderId);
        Task ChangeShippingAddress(Address shippingAddr, string orderId);
        Task AddOrderItem(string orderId, List<string> orderItemId);
        Task RemoveOrderItem(string orderId, List<string> orderItemId);


    }
}
