using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using ECommerce.Core.Interfaces;
using ECommerce.Core.Models;
using ECommerce.Core.Models.OrderAggregate;
using Ardalis.GuardClauses;

namespace ECommerce.Core.BusinessServices
{
    public class OrderService 
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
            Guard.Against.NullOrEmpty(orderId, nameof(orderId));
            Guard.Against.NullOrEmpty(orderItemId, nameof(orderItemId));

            throw new NotImplementedException();
        }

        public async Task CancelOrder(string orderId)
        {
            Guard.Against.NullOrEmpty(orderId, nameof(orderId));

            var order = await _orderRepository.GetByIdAsync(orderId);
            //var status = EnumExtensions.ToDescriptionString(OrderStatus.Cancelled);
            order.Status =  OrderStatus.Cancelled;
        }

        public async Task CheckoutCart(string cartId)
        {
            Guard.Against.NullOrEmpty(cartId, nameof(cartId));

            var order = new Order();
            order.Id = Guid.NewGuid().ToString();
            var orderitems = new List<OrderItem>();

            var cart = await _cartRepository.GetByIdAsync(cartId);

            cart.CartItems.ToList().ForEach(i => orderitems.Add(new OrderItem
            {
                OrderId = order.Id,
                ProductId = i.ProductId,
                Id = Guid.NewGuid().ToString(),
                Quantity = i.Quantity,
                UnitPrice = i.UnitPrice,
                TotalPrice = i.Quantity * i.UnitPrice
            }));
            //var status = EnumExtensions.ToDescriptionString(OrderStatus.PendingSubmitted);
            order.Status = OrderStatus.Ready;
            order.CartId = cart.Id;

            _orderRepository.Insert(order);

            // TODO : Sending message to the Payment service.
        }

        public async Task RemoveOrderItem(string orderId, string orderItemId)
        {
            Guard.Against.NullOrEmpty(orderId, nameof(orderId));
            Guard.Against.NullOrEmpty(orderItemId, nameof(orderItemId));

            await _orderRepository.RemoveOrderItem(orderId,orderItemId);
        }

        public Task ChangeShippingAddress(Address shippingAddr, string orderId)
        {
            throw new NotImplementedException();
        }

        public async Task InvoiceOrder(string orderId)
        {
            var order = await _orderRepository.GetByIdAsync(orderId);
            //var status= EnumExtensions.ToDescriptionString(OrderStatus.Submitted);
            order.Status = OrderStatus.Submitted;
        }

    }
}
