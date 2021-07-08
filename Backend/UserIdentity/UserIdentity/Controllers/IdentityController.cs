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
using UserIdentity.Models;
using UserIdentity.Services;

namespace UserIdentity.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IdentityController : ApiController
    {
        private readonly UserManager<EcUser> userManager;
        //private readonly RoleManager<EcRole> rolemanager;
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;
        private readonly ApplicationSettings appSettings;
        public IdentityController(IUserService userService, UserManager<EcUser> userManager, IConfiguration configuration, /*RoleManager<EcRole>  roleManager, */IOptions<ApplicationSettings> appSettings)
        {
            this.userManager = userManager;
            //this.rolemanager = roleManager;
            this.appSettings = appSettings.Value;
            this._configuration = configuration;
            this._userService = userService;
        }

        [Route(nameof(Register))]
        public async Task<ActionResult> Register(RegisterUserRequestModel model)
        {
            var user = new EcUser
            {
                Email = model.Email,
                FirstName = "a",
                LastName = "b",
                UserName = model.Username,
            };
            var result = await this.userManager.CreateAsync(user, model.Password);
            if(result.Succeeded)
            {
                return Ok(); 
            }
            return BadRequest(result.Errors);
        }

        [Route(nameof(RegisterAdmin))]
        public async Task<ActionResult> RegisterAdmin([FromBody]RegisterUserRequestModel model)
        {
            var userExists = await userManager.FindByNameAsync(model.Username);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });


            EcUser user = new EcUser()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username
            };
            var result = await userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });

            //if (!await rolemanager.RoleExistsAsync(.Admin))
            //    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
            //if (!await roleManager.RoleExistsAsync(UserRoles.User))
            //    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

            //if (await roleManager.RoleExistsAsync(UserRoles.Admin))
            //{
            //    await userManager.AddToRoleAsync(user, UserRoles.Admin);
            //}

            return Ok(new Response { Status = "Success", Message = "User created successfully!" });


        }



        [Route(nameof(Login))]
        public async Task<ActionResult<string>> Login([FromBody]LoginRequestModel loginModel)
         {
            var user = await this.userManager.FindByNameAsync(loginModel.Username);
            if(user == null)
            {
                return this.Unauthorized();
            }
            var passwordValid = await this.userManager.CheckPasswordAsync(user, loginModel.Password);
            if(!passwordValid)
            {
                return this.Unauthorized();
            }

            //var userRoles = await userManager.GetRolesAsync(user);
            //var authClaims = new List<Claim>
            //{
            //    new Claim(ClaimTypes.Name, user.UserName),
            //    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            //};
            //foreach (var userRole in userRoles)
            //{
            //    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
            //}



            var authenCheck = _userService.Authenticate(loginModel);

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(this.appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var encryptedToken = tokenHandler.WriteToken(token);
            return Ok(encryptedToken);
        }



    }
}
