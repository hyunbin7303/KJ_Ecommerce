using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

#nullable disable

namespace UserIdentity
{
    public partial class EcUserRole : IdentityUserRole<string>
    {
        public virtual EcRole Role { get; set; }
        public virtual EcUser User { get; set; }
    }
}
