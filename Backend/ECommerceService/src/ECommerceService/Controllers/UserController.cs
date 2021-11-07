using ECommerce.Core.Interfaces;
using ECommerce.Core.Models;
using ECommerce.Interfaces;
using ECommerce.Query;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ECommerceService.Controllers
{
    [Authorize]
    public class UserController : BaseController
    {
        private IUserService _userService =null;
        public UserController(IUserService userService)
        {
            _userService = userService ?? null;
        }
        [HttpPost("user")]
        public ActionResult<Customer> CreateUser(CreateCustomerDTO createCustomerDTO)
        {
            Customer customer = new Customer();
            customer.Id = createCustomerDTO.UserId;
            return Ok();
        }

        [HttpGet("Get")]
        public ActionResult Get()
        {
            var claimsIdentity = this.User.Identity as ClaimsIdentity;
            var userId = claimsIdentity.FindFirst("UserName")?.Value;
            var firstName = claimsIdentity.FindFirst("FirstName")?.Value;
            var lastName = claimsIdentity.FindFirst("LastName")?.Value;
            var vendorId = claimsIdentity.FindFirst("VendorId")?.Value;

            return Ok(userId);
        }

        [HttpGet("GetUserId")]
        public ActionResult GetUserId()
        {
            var claimsIdentity = this.User.Identity as ClaimsIdentity;
            var userId = claimsIdentity.FindFirst("UserName")?.Value;
            return Ok(userId);
        }

    }
}
