using System.Threading.Tasks;
using BLL.Helpers.MailHelper.Entities;

namespace BLL.Helpers.MailHelper
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}