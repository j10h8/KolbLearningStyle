namespace kolb_learning_style.Services
{
    using MimeKit;
    using System.Threading.Tasks;

    public interface IEmailService
    {
        Task SendEmailAsync(string toEmail, string subject, MimeMessage emailMessage);
        Task<bool> AddEmailAddressAsync(string emailAddress);
    }
}
