using kolb_learning_style.Repositories;
using MailKit.Net.Smtp;
using MimeKit;

namespace kolb_learning_style.Services
{
	public class EmailService : IEmailService
	{
		private readonly SmtpClient _smtpClient;
		private readonly IEmailRepository emailRepository;

		public EmailService(IEmailRepository emailRepository)
		{
			_smtpClient = new SmtpClient();

			this.emailRepository = emailRepository;
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

		public async Task<bool> AddEmailAddressAsync(string emailAddress)
		{
			return await emailRepository.AddEmailAddressAsync(emailAddress);
		}
	}
}
