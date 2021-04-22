using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Infrastructure.Models
{
    public partial class EcRole
    {
        public EcRole()
        {
            EcRoleClaims = new HashSet<EcRoleClaim>();
            EcUserRoles = new HashSet<EcUserRole>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string ConcurrencyStamp { get; set; }

        public virtual ICollection<EcRoleClaim> EcRoleClaims { get; set; }
        public virtual ICollection<EcUserRole> EcUserRoles { get; set; }
    }
}
