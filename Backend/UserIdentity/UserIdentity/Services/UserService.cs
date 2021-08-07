using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using UserIdentity.Models;

namespace UserIdentity.Services
{     
    public class UserService : IUserService
    {
        private readonly ApplicationSettings _appSettings;
        private readonly UserManager<EcUser> userManager;
        private readonly SignInManager<EcUser> signInManager;
        public UserService(IOptions<ApplicationSettings> appSettings, UserManager<EcUser> userManager, SignInManager<EcUser> signinManager)
        {
            this._appSettings = appSettings.Value;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        private List<EcUser> _users = new List<EcUser>
        {
            new EcUser {  UserName = "test", PasswordHash = "test" }
        };
        public AuthenticateResponse Authenticate(LoginRequestModel model)
        {
            var user = this.userManager.FindByNameAsync(model.Username).Result;
            if (user == null) return null;
            // authentication successful so generate jwt token
            var token = generateJwtToken(user);
            return new AuthenticateResponse(user, token);
        }

        public IEnumerable<EcUser> GetAll()
        {
            return _users;
        }
        public EcUser GetById(string id)
        {
            return _users.FirstOrDefault(x => x.Id == id);
        }


        // helper methods
        private string generateJwtToken(EcUser user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

    }
    //https://jasonwatmore.com/post/2021/04/30/net-5-jwt-authentication-tutorial-with-example-api#tools-required
}
