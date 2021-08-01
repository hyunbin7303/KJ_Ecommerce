using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace UserIdentity.Infrastructure
{
    public class MyUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<EcUser, EcUserRole>
    {
        public MyUserClaimsPrincipalFactory(
            UserManager<EcUser> userManager,
            RoleManager<EcUserRole> roleManager,
            IOptions<IdentityOptions> optionsAccessor)
            : base(userManager, roleManager, optionsAccessor)
        {
            if(userManager == null)
            {
                throw new ArgumentNullException(nameof(userManager));
            }
            if(optionsAccessor == null || optionsAccessor.Value == null)
            {
                throw new ArgumentException(nameof(optionsAccessor));
            }
        }
        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(EcUser user)
        {
            var userId = await UserManager.GetUserIdAsync(user);
            var userName = await UserManager.GetUserNameAsync(user);
            var id = new ClaimsIdentity("Identity.Application", // REVIEW: Used to match Application scheme
                Options.ClaimsIdentity.UserNameClaimType,
                Options.ClaimsIdentity.RoleClaimType);
            id.AddClaim(new Claim(Options.ClaimsIdentity.UserIdClaimType, userId));
            id.AddClaim(new Claim(Options.ClaimsIdentity.UserNameClaimType, userName));

            if (UserManager.SupportsUserSecurityStamp)
            {
                id.AddClaim(new Claim(Options.ClaimsIdentity.SecurityStampClaimType,
                    await UserManager.GetSecurityStampAsync(user)));
            }
            //if (UserManager.SupportsUserClaim)
            //{d
            //    id.AddClaims(await UserManager.GetClaimsAsync(user));
            //}
            id.AddClaim(new Claim("UserName", user.UserName ?? ""));
            //https://github.com/aspnet/Identity/blob/master/src/Core/UserClaimsPrincipalFactory.cs
            return id;
        }
    }
}
//https://benfoster.io/blog/customising-claims-transformation-in-aspnet-core-identity/
//https://docs.microsoft.com/en-us/aspnet/core/security/authentication/add-user-data?view=aspnetcore-5.0&tabs=visual-studio

//https://www.youtube.com/watch?v=RBMO_hruKaI
