using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

#nullable disable

namespace UserIdentity
{
    public partial class EcRoleClaim : IdentityRoleClaim<string>
    {
        public virtual EcRole Role { get; set; }
    }
}
