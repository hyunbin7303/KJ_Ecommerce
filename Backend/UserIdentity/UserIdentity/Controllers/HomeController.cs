using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
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
            var token = HttpContext.GetTokenAsync("Bearer", "access_token").Result;
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);
            //var key = Encoding.ASCII.GetBytes(token);
            //var validations = new TokenValidationParameters
            //{
            //    ValidateIssuerSigningKey = true,
            //    IssuerSigningKey = new SymmetricSecurityKey(key),
            //    ValidateIssuer = false,
            //    ValidateAudience = false
            //};
            //var claims = handler.ValidateToken(token, validations, out var tokenSecure);
            //var test = jwtSecurityToken.Claims.First(claim => claim.Type == "jti").Value;
            //var username = jwtSecurityToken.Claims.First(claim => claim.Type == "UserName").Value;


            var principal = HttpContext.User;
            if (principal?.Claims != null)
            {
                foreach (var claim in principal.Claims)
                {
                }

            }
            var check = principal?.Claims?.SingleOrDefault(p => p.Type == "username")?.Value;
            return Ok(check);
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
