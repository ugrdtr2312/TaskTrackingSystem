using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BLL.DTOs.Project
{
    public class AddUserToProjectDto
    {
        [Required, NotNull]
        public int ProjectId { get; set; }
        [Required, NotNull]
        public int UserId { get; set; }
    }
}