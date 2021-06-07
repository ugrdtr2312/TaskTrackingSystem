using System.Threading.Tasks;
using BLL.DTOs.Project;
using BLL.DTOs.User;
using BLL.Helpers.MailHelper.Entities;

namespace BLL.Services.Interfaces
{
    public interface IMailService
    {
        Task SendEmailAboutAddingToProjectAsync(UserToProjectDto userToProjectDto);
        Task SendEmailRemovingFromProjectAsync(UserToProjectDto userToProjectDto);
        Task SendEmailAboutSigningInAsync(LoginDto loginDto);
        Task SendEmailAboutSigningUpAsync(int userId);
    }
}