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
    public class IdentityController : ApiController
    {
        private readonly UserManager<EcUser> _userManager;
        private readonly SignInManager<EcUser> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;
        private readonly ApplicationSettings appSettings;
        private readonly MyUserClaimsPrincipalFactory _factory;

        public IdentityController(
            IUserService userService,
            UserManager<EcUser> userManager,
            SignInManager<EcUser> signInManager,
            IConfiguration configuration, 
            IOptions<ApplicationSettings> appSettings, 
            MyUserClaimsPrincipalFactory myUserClaimsPrincipalFactory
            )
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this.appSettings = appSettings.Value;
            this._configuration = configuration;
            this._userService = userService;
            this._factory = myUserClaimsPrincipalFactory;
        }

        [Route(nameof(Register))]
        public async Task<ActionResult> Register(RegisterUserRequestModel model)
        {
            var user = new EcUser
            {
                FirstName = model.Firstname,
                LastName = model.Lastname,
                Email = model.Email,
                UserName = model.Username,
            };
            var userExists = await _userManager.FindByNameAsync(model.Username);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });

            var result = await this._userManager.CreateAsync(user, model.Password);
            await _userManager.AddClaimAsync(user, new Claim("UserName",user.UserName));
            await _factory.CreateAsync(user);
            if (result.Succeeded)
            {
                return Ok(); 
            }
            return BadRequest(result.Errors);
        }
     




        [Route(nameof(Login))]
        public async Task<ActionResult<string>> Login([FromBody]LoginRequestModel loginModel)
         {
            var user = await this._userManager.FindByNameAsync(loginModel.Username);
            if (user == null)
            {
                return this.Unauthorized();
            }
            var passwordValid = await this._userManager.CheckPasswordAsync(user, loginModel.Password);
            if (!passwordValid)
            {
                return this.Unauthorized();
            }
            var authenCheck = _userService.Authenticate(loginModel);
            return Ok(authenCheck);
        }

        [HttpPost(nameof(SignOut))]
        public async Task SignOut()
        {
            await _signInManager.SignOutAsync();
        }

    }
}
