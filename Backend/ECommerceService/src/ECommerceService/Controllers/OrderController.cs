using ECommerce.Infrastructure.BusinessServices;
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
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
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
        public async Task<IActionResult> RemoveOrderItem(string orderId, List<string> orderItemId)
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
