using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

#nullable disable

namespace UserIdentity
{
    public partial class EcUserRole : IdentityRole
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }

        public virtual EcRole Role { get; set; }
        public virtual EcUser User { get; set; }
    }
}
