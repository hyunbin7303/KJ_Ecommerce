using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Infrastructure.Models
{
    public partial class EcUserClaim
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual EcUser User { get; set; }
    }
}
