using ECommerce.Core.Interfaces;
using ECommerce.Core.Models;
using ECommerce.Core.Models.OrderAggregate;
using ECommerce.Services;
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
        private const string SampleUser1 = "Evan1234";
        private const string SampleUser2 = "habib0303";

        private readonly ICustomerRepository _customerRepository;
        private readonly OrderService _orderService;
        private readonly IOrderRepository _orderRepository;
        // private readonly UserService _userService;
        public OrderController(ICustomerRepository customerRepository, IOrderRepository orderRepository, ICartRepository cartRepository)
        {
            _customerRepository = customerRepository ?? null;
            _orderService = new OrderService(orderRepository,cartRepository) ?? null;
            _orderRepository = orderRepository ?? null;
        }

        [HttpGet("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<Order> Get()
        {
            var allOrders = _orderRepository.GetAll();
            return allOrders;
        }

        [HttpGet("orderitem")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<OrderItem> OrderItemByOrderId(string orderId)
        {
            //var allOrders = _orderService.
            //return allOrders;
            return null;
        }

        [HttpGet("GetOrder")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IEnumerable<Order>> GetOrderAsync(string orderId)
        {
            var customer = await _customerRepository.GetByIdAsync(SampleUser1);
            if (customer != null)
            {

            }
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
