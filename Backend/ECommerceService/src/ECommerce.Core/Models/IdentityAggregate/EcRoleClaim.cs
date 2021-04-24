using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Core.Models
{
    public class EcRoleClaim
    {
        public int Id { get; set; }
        public string RoleId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual EcRole Role { get; set; }
    }
}
