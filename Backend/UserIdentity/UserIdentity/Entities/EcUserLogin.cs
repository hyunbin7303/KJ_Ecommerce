using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
#nullable disable

namespace UserIdentity
{
    public partial class EcUserLogin : IdentityUserLogin<string>
    {


        public virtual EcUser User { get; set; }
    }
}
