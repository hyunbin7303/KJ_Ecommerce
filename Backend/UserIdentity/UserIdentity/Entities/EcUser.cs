using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace UserIdentity
{
    public partial class EcUser : IdentityUser<string>
    {
        public EcUser()
        {
            EcUserClaims = new HashSet<EcUserClaim>();
            EcUserLogins = new HashSet<EcUserLogin>();
            EcUserRoles = new HashSet<EcUserRole>();
            EcUserTokens = new HashSet<EcUserToken>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override string Id { get; set; }


        public virtual ICollection<EcUserClaim> EcUserClaims { get; set; }
        public virtual ICollection<EcUserLogin> EcUserLogins { get; set; }
        public virtual ICollection<EcUserRole> EcUserRoles { get; set; }
        public virtual ICollection<EcUserToken> EcUserTokens { get; set; }
    }
}
