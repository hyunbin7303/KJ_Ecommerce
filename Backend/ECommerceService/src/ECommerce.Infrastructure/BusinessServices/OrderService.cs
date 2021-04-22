using ECommerce.Domain.Models.OrderAggregate;
using ECommerce.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using ECommerce.Domain.Models;

namespace ECommerce.Infrastructure.BusinessServices
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ICartRepository _cartRepository;

        public OrderService(IOrderRepository orderRepository, ICartRepository cartRepository)
        {
            _orderRepository = orderRepository;
            _cartRepository = cartRepository;
        }

        public Task AddOrderItem(string orderId, List<string> orderItemId)
        {
            throw new NotImplementedException();
        }

        public async Task CancelOrder(string orderId)
        {
            var order = await _orderRepository.GetByIdAsync(orderId);
            order.Status = OrderStatus.Cancelled;
        }


        public async Task<Order> CheckoutCart(string cartId)
        {
            var order = new Order();          
            var orderitems = new List<OrderItem>();

            var cart = await _cartRepository.GetByIdAsync(cartId);

            cart.CartItems.ToList().ForEach(i => orderitems.Add(new OrderItem
            { 
                OrderId = Guid.NewGuid().ToString(),
                ProductId = i.ProductId,
                
            }));

            order.Status = OrderStatus.PendingSubmitted;
            return order;                       
        }

        public Task RemoveOrderItem(string orderId, List<string> orderItemId)
        {
            throw new NotImplementedException();
        }

        public Task ChangeShippingAddress(Address shippingAddr, string orderId)
        {
            throw new NotImplementedException();
        }

        public async Task InvoiceOrder(string orderId)
        {
            var order = await _orderRepository.GetByIdAsync(orderId);

            order.Status = OrderStatus.Submitted;
        }
    }
}
