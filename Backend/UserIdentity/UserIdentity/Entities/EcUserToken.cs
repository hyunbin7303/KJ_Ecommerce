using System;
using System.Collections.Generic;

#nullable disable

namespace UserIdentity
{
    public partial class EcUserToken
    {
        public string UserId { get; set; }
        public string LoginProvider { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual EcUser User { get; set; }
    }
}
