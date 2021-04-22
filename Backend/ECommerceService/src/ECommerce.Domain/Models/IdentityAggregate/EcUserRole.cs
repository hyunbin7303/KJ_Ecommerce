using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Infrastructure.Models
{
    public partial class EcUserRole
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }

        public virtual EcRole Role { get; set; }
        public virtual EcUser User { get; set; }
    }
}
