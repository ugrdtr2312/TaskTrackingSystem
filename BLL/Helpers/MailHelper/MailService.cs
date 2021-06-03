using System.Threading.Tasks;
using BLL.Helpers.MailHelper.Entities;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;

namespace BLL.Helpers.MailHelper
{
    public class MailService : IMailService
    {
        private readonly MailSettings _mailSettings;
        
        public MailService(IOptions<MailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }
        
        public async Task SendEmailAsync(MailRequest mailRequest)
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
    }
}