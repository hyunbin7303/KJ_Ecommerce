using ECommerce.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace ECommerce.Core.Models
{
    // TODO : This class needs  to be updated.
    public class User : Entity<int>
    {
        public User()
        {
            //UserVendors = new HashSet<UserVendor>();
            LatestUpdateTime = DateTimeOffset.UtcNow;
        }


        public string Account       { get;  set; }
        public string FirstName     { get;  set; }
        public string LastName      { get;  set; }

        public string Email         { get;  set; }
        public bool EmailVerified   { get;  set; }
        public string Address       { get;  set; }
        public string Address2      { get;  set; }
        public string Country       { get;  set; }
        [RegularExpression(@"^\d{5}(?:[-\s]\d{4})?$", ErrorMessage= "Enter a valid zip code.")]
        public string ZipCode       { get;  set; }
        public bool IsActive        { get;  set; }
        public string? PhoneNumber  { get;  set; }
        public int? VendorId         { get;  set; }
        public string? Description  { get;  set; } = null;
        public DateTimeOffset LatestUpdateTime      { get; set; }
        //public ICollection<UserVendor> UserVendors { get; set; }

    }
}
