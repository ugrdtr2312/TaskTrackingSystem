using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BLL.DTOs.User
{
    public class RegistrationDto
    {
        [Required, NotNull]
        public string FirstName { get; set; }
        [Required, NotNull]
        public string Surname { get; set; }
        [Required, NotNull]
        public string UserName { get; set; }
        [Required, NotNull]
        public string Password { get; set; }
        [Required, NotNull]
        public string Email { get; set; }
    }
}