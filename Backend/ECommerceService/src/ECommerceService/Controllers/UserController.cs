using ECommerce.Core.Interfaces;
using ECommerce.Core.Models;
using ECommerce.Interfaces;
using ECommerce.Query;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ECommerceService.Controllers
{
    public class UserController : BaseController
    {
        private IUserService _userService =null;
        public UserController(IUserService userService)
        {
            _userService = userService ?? null;
        }
        [HttpPost("user")]
        public ActionResult<Customer> CreateUser(CreateUserDTO createUserDTO)
        {
            _userService.CreateUserAsync(createUserDTO);
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

        [Authorize]
        [HttpGet("GetCurrentUser")]
        public ActionResult GetCurrentUser()
        {
            var claimsIdentity = this.User.Identity as ClaimsIdentity;
            var user = _userService.GetCurrentUserAsync(claimsIdentity);
            return Ok(user);
        }

    }
}
