﻿
namespace UserIdentity.Models
{
    using System.ComponentModel.DataAnnotations;
    public class RegisterUserRequestModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Username { get; set; }
        [Required(ErrorMessage ="Password is required.")]
        public string Password { get; set; }

    }
}
