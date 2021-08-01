using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace UserIdentity.Infrastructure
{
    public class UserInfoClaims : IClaimsTransformation
    {
        public Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
        {
            if (!principal.HasClaim(c => c.Type == ClaimTypes.Country))
            {
                ClaimsIdentity id = new ClaimsIdentity();
                id.AddClaim(new Claim(ClaimTypes.Country, "Canada"));
                principal.AddIdentity(id);
            }
            return Task.FromResult(principal);
        }
    }
}
