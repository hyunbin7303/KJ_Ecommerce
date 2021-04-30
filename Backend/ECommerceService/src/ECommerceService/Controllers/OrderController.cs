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
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : BaseController
    {
        private readonly OrderService _orderService;

        public OrderController(IOrderRepository orderRepository,ICartRepository cartRepository)
        {
            _orderService = new OrderService(orderRepository,cartRepository);
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
        public async Task<IActionResult> InvoiceOrder(string orderId)
        {
            await _orderService.InvoiceOrder(orderId);
            return Ok();
        }

    }
}
