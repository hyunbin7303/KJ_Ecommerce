using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

#nullable disable

namespace UserIdentity
{
    public partial class EcUserClaim : IdentityUserClaim<string>
    {
        public virtual EcUser User { get; set; }
    }
}
