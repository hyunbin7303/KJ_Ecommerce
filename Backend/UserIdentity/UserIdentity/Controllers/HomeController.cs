using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using UserIdentity.Controllers;
using UserIdentity.Models;
using UserIdentity.Services;

namespace UserIdentity
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ApiController
    {
        private IUserService _userService;
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }
        [Authorize]
        public ActionResult Get()
        {

            return Ok("Works");
        }
        [Authorize]
        [HttpGet("GetUserId")]
        public ActionResult GetUserId()
        {
            var claimsIdentity = this.User.Identity as ClaimsIdentity;
            var userId = claimsIdentity.FindFirst("UserName")?.Value;
            return Ok(userId);
        }



        [HttpPost("authenticate")]
        public IActionResult Authenticate(LoginRequestModel model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }


        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
    } 
}
