using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BLL.DTOs.Project
{
    public class AddUserToProjectDto
    {
        [Required(ErrorMessage = "ProjectId is required and shouldn't be null"), NotNull]
        public int ProjectId { get; set; }
        [Required(ErrorMessage = "UserId is required and shouldn't be null"), NotNull]
        public int UserId { get; set; }
    }
}