﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BLL.DTOs.User
{
    public class RegistrationDto
    {
        [Required(ErrorMessage = "FirstName is required and shouldn't be null"), NotNull]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Surname is required and shouldn't be null"), NotNull]
        public string Surname { get; set; }
        [Required(ErrorMessage = "UserName is required and shouldn't be null"), NotNull]
        public string UserName { get; set; }
        [StringLength(10, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 4)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Email is required and shouldn't be null"), EmailAddress]
        public string Email { get; set; }
    }
}