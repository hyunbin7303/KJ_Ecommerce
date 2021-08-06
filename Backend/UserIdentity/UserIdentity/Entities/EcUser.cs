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
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
