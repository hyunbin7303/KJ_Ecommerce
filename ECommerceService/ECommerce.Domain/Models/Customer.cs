using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerce.Domain.Models
{
    public class Customer : Entity
    {
        [Required]   
        public string CustomerId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage ="First name cannot exceed 100 characters.")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool EmailVerified { get; set; }
        public string Address { get; set; }
        public string? Address2 { get; set; }
        public string Country { get; set; }
        [Required]
        [RegularExpression(@"^\d{5}(?:[-\s]\d{4})?$", ErrorMessage= "Enter a valid zip code.")]
        public string ZipCode { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Description { get; set; }
        public virtual List<Invoice> Invoices { get; set; }
    }
}
