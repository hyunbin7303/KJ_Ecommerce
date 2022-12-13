using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Core.Models
{
    public class EcUser
    {
        public EcUser()
        {
            EcUserClaims = new HashSet<EcUserClaim>();
            EcUserLogins = new HashSet<EcUserLogin>();
            EcUserRoles = new HashSet<EcUserRole>();
            EcUserTokens = new HashSet<EcUserToken>();
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }

        public virtual ICollection<EcUserClaim> EcUserClaims { get; set; }
        public virtual ICollection<EcUserLogin> EcUserLogins { get; set; }
        public virtual ICollection<EcUserRole> EcUserRoles { get; set; }
        public virtual ICollection<EcUserToken> EcUserTokens { get; set; }
    }
}
