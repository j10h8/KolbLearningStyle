using MailKit.Net.Smtp;
using MimeKit;
using System.Threading.Tasks;

namespace kolb_learning_style.Services
{
	public class EmailService : IEmailService
	{
		private readonly SmtpClient _smtpClient;

		public EmailService()
		{
			_smtpClient = new SmtpClient();
		}

		public async Task SendEmailAsync(string toEmail, string subject, MimeMessage emailMessage)
		{
			
			_smtpClient.ServerCertificateValidationCallback = (s, c, h, e) => true; 
			await _smtpClient.ConnectAsync("smtp.Gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
			await _smtpClient.AuthenticateAsync("email", "password");

			// Send the email
			await _smtpClient.SendAsync(emailMessage);

			// Disconnect and close the client
			await _smtpClient.DisconnectAsync(true);
		}
	}
}
