using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

#nullable disable

namespace UserIdentity
{
    public partial class EcUser : IdentityUser
    {
        public EcUser()
        {
            EcUserClaims = new HashSet<EcUserClaim>();
            EcUserLogins = new HashSet<EcUserLogin>();
            EcUserRoles = new HashSet<EcUserRole>();
            EcUserTokens = new HashSet<EcUserToken>();
        }
        public virtual ICollection<EcUserClaim> EcUserClaims { get; set; }
        public virtual ICollection<EcUserLogin> EcUserLogins { get; set; }
        public virtual ICollection<EcUserRole> EcUserRoles { get; set; }
        public virtual ICollection<EcUserToken> EcUserTokens { get; set; }
    }
}
