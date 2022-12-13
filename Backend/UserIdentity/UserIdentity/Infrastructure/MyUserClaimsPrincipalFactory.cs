using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace UserIdentity.Infrastructure
{
    public class MyUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<EcUser>
    {
        public MyUserClaimsPrincipalFactory(
            UserManager<EcUser> userManager,
            IOptions<IdentityOptions> optionsAccessor)
            : base(userManager, optionsAccessor)
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
            var identity = await base.GenerateClaimsAsync(user);
            identity.AddClaim(new Claim("UserName", user.UserName ?? ""));
            identity.AddClaims(await UserManager.GetClaimsAsync(user));
            return identity;
        }
    }
}
//https://benfoster.io/blog/customising-claims-transformation-in-aspnet-core-identity/
//https://docs.microsoft.com/en-us/aspnet/core/security/authentication/add-user-data?view=aspnetcore-5.0&tabs=visual-studio
//https://www.youtube.com/watch?v=RBMO_hruKaI
