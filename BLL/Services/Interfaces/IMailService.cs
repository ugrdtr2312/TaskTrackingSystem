using System.Threading.Tasks;
using BLL.DTOs.Project;
using BLL.Helpers.MailHelper.Entities;

namespace BLL.Services.Interfaces
{
    public interface IMailService
    {
        Task SendEmailAboutAddingToProjectAsync(AddUserToProjectDto addUserToProjectDto);
    }
}