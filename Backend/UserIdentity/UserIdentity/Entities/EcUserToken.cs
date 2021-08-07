using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

#nullable disable

namespace UserIdentity
{
    public partial class EcUserToken : IdentityUserToken<string>
    {
        public virtual EcUser User { get; set; }
    }
}
