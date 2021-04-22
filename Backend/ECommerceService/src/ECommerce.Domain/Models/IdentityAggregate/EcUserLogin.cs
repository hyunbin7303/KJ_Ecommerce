using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Infrastructure.Models
{
    public partial class EcUserLogin
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        public string UserId { get; set; }

        public virtual EcUser User { get; set; }
    }
}
