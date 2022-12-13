using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using UserIdentity.Infrastructure;
using UserIdentity.Models;
using UserIdentity.Services;

namespace UserIdentity.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : ApiController
    {
        private readonly RoleManager<IdentityRole> _rolemanager;
        private readonly UserManager<EcUser> _userManager;


        public AdminController(RoleManager<IdentityRole> roleManager, UserManager<EcUser> userManager)
        {
            _rolemanager = roleManager;
            _userManager = userManager;
        }



        [Route(nameof(RegisterAdmin))]
        public async Task<ActionResult> RegisterAdmin([FromBody] RegisterUserRequestModel model)
        {
            var userExists = await _userManager.FindByNameAsync(model.Username);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });

            EcUser user = new EcUser()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });

            if (!await _rolemanager.RoleExistsAsync("Admin"))
                await _rolemanager.CreateAsync(new IdentityRole());
            if (await _rolemanager.RoleExistsAsync("Admin"))
            {
                await _userManager.AddToRoleAsync(user, "Admin");
            }
            return Ok(new Response { Status = "Success", Message = "User created successfully!" });
        }



    }
}
