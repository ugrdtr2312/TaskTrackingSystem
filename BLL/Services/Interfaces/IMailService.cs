using System.Threading.Tasks;
using BLL.DTOs.Project;
using BLL.DTOs.User;
using BLL.Helpers.MailHelper.Entities;

namespace BLL.Services.Interfaces
{
    public interface IMailService
    {
        Task SendEmailAboutAddingToProjectAsync(AddUserToProjectDto addUserToProjectDto);
        Task SendEmailAboutSigningInAsync(LoginDto loginDto);
        Task SendEmailAboutSigningUpAsync(int userId);
    }
}