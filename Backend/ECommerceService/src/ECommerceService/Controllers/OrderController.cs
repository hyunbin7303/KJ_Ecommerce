using ECommerce.Core.BusinessServices;
using ECommerce.Core.Interfaces;
using ECommerce.Core.Models.OrderAggregate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceService.Controllers
{
    public class OrderController : BaseController
    {
        private readonly OrderService _orderService;
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository, ICartRepository cartRepository)
        {
            _orderService = new OrderService(orderRepository,cartRepository);
            _orderRepository = orderRepository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<Order> Get()
        {
            var allOrders = _orderRepository.GetAll();
            return allOrders;
        }

        [HttpPost("CheckoutCart")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> CheckoutCart(string shoppingCartId)
        {
            await _orderService.CheckoutCart(shoppingCartId);
            return Ok();
        }
        [HttpPost("RemoveOrderItem")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> RemoveOrderItem(string orderId, string orderItemId)
        {
            await _orderService.RemoveOrderItem(orderId, orderItemId);
            return Ok();
        }
        [HttpPost("InvoiceOrder")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> InvoiceOrder(string orderId)
        {
            await _orderService.InvoiceOrder(orderId);
            return Ok();
        }

    }
}
