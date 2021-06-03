using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BLL.DTOs.User
{
    public class LoginDto
    {
        [Required, NotNull]
        public string UserName { get; set; }
        [Required, NotNull]
        public string Password { get; set; }
    }
}