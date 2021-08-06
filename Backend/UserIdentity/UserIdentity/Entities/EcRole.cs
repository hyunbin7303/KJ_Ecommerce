using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

#nullable disable

namespace UserIdentity
{
    public partial class EcRole : IdentityRole<string>
    {
        public EcRole() : base()
        {
            EcRoleClaims = new HashSet<EcRoleClaim>();
            EcUserRoles = new HashSet<EcUserRole>();
        }
        public EcRole(string rolename)
        {
            Name = rolename;
        }
        public virtual ICollection<EcRoleClaim> EcRoleClaims { get; set; }
        public virtual ICollection<EcUserRole> EcUserRoles { get; set; }
    }
}
