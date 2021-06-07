using System.Threading.Tasks;
using BLL.DTOs.Project;
using BLL.DTOs.User;
using BLL.Exceptions;
using BLL.Helpers.MailHelper.Entities;
using BLL.HelpModels;
using BLL.Services.Interfaces;
using DAL.Interfaces;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MimeKit;

namespace BLL.Services.Realizations
{
    public class MailService : IMailService
    {
        private readonly IUoW _uow;
        private readonly MailSettings _mailSettings;
        
        public MailService(IOptions<MailSettings> mailSettings, IUoW uow)
        {
            _uow = uow;
            _mailSettings = mailSettings.Value;
        }
        
        private async Task SendEmailAsync(MailRequest mailRequest)
        {
            var email = new MimeMessage {Sender = new MailboxAddress(_mailSettings.DisplayName, _mailSettings.Mail)};
            email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
            email.Subject = mailRequest.Subject;
            email.Body = new BodyBuilder {HtmlBody = mailRequest.Body}.ToMessageBody();
            
            using var smtp = new SmtpClient();
            await smtp.ConnectAsync(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(_mailSettings.Mail, _mailSettings.Password);
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }

        public async Task SendEmailAboutAddingToProjectAsync(UserToProjectDto userToProjectDto)
        {
            var project = await _uow.Projects.GetByIdAsyncAsTracking(userToProjectDto.ProjectId);
            
            if (project == null)
                throw new DbQueryResultNullException("This project doesn't exist");
            
            var user = await _uow.UserManager.Users.FirstOrDefaultAsync(u => u.Id == userToProjectDto.UserId);
            
            if (user == null) 
                throw new DbQueryResultNullException("This user doesn't exist");

            await SendEmailAsync(new MailRequest()
            {
                ToEmail = user.Email,
                Subject = "You were added to new project",
                Body = $"Hi! Welcome in {project.Name}!!!"
            });
        }

        public async Task SendEmailRemovingFromProjectAsync(UserToProjectDto userToProjectDto)
        {
            var project = await _uow.Projects.GetByIdAsyncAsTracking(userToProjectDto.ProjectId);
            
            if (project == null)
                throw new DbQueryResultNullException("This project doesn't exist");
            
            var user = await _uow.UserManager.Users.FirstOrDefaultAsync(u => u.Id == userToProjectDto.UserId);
            
            if (user == null) 
                throw new DbQueryResultNullException("This user doesn't exist");

            await SendEmailAsync(new MailRequest()
            {
                ToEmail = user.Email,
                Subject = "You were removed from project",
                Body = $"You are not more a part of {project.Name}!!!"
            });
        }

        public async Task SendEmailAboutSigningInAsync(LoginDto loginDto)
        {
            var user = await _uow.UserManager.FindByNameAsync(loginDto.UserName);
            
            if (user == null)
                throw new InvalidDataException("User with this login doesn't exist");

            await SendEmailAsync(new MailRequest()
            {
                ToEmail = user.Email,
                Subject = "Account has been logged in",
                Body = "If it wasn't you then contact admin!!!"
            });
        }

        public async Task SendEmailAboutSigningUpAsync(int userId)
        {
            var user = await _uow.UserManager.Users.FirstOrDefaultAsync(u => u.Id == userId);
            
            if (user == null)
                throw new InvalidDataException("User with this login doesn't exist");

            await SendEmailAsync(new MailRequest()
            {
                ToEmail = user.Email,
                Subject = $"Hi, {user.FirstName}! Welcome in our system.",
                Body = "We are happy that you are a part of us)"
            });
        }
    }
}