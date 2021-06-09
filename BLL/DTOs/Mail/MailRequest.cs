namespace BLL.DTOs.Mail
{
    public class MailRequest
    {
        public string ToEmail { get; init; }
        public string Subject { get; init; }
        public string Body { get; init; }
    }
}