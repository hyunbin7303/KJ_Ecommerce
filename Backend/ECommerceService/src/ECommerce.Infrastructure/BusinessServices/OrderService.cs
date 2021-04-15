using ECommerce.Domain.Models.OrderAggregate;
using ECommerce.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

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

        public Task CancelOrder(string orderId)
        {
            throw new NotImplementedException();
        }

        public Task CheckoutOrder(string orderId)
        {
            throw new NotImplementedException();
        }

        public async Task CreateOrder(string cartId)
        {
            throw new NotImplementedException();
            var order = new Order();
          
            var orderitems = new List<OrderItem>();

            var cart = await _cartRepository.GetByIdAsync(cartId);

            cart.CartItems.ToList().ForEach(i => orderitems.Add(new OrderItem
            { 
                OrderId = order.Id,
                 
            }));


            foreach(var item in cart.CartItems)
            {
               
            }
           
        }

        public Task RemoveOrderItem(string orderId, List<string> orderItemId)
        {
            throw new NotImplementedException();
        }
    }
}
