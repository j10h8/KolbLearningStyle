using kolb_learning_style.Models;
using kolb_learning_style.Repositories;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using Microsoft.JSInterop;
using MimeKit;

namespace kolb_learning_style.Services
{
	public class EmailService : IEmailService
	{
		private readonly SmtpClient _smtpClient;
		private readonly IEmailRepository emailRepository;
		private readonly IJSRuntime jSRuntime;
		private readonly IOptions<EmailSettings> emailSettingsOptions;

		public EmailService(IEmailRepository emailRepository, IJSRuntime jSRuntime, IOptions<EmailSettings> EmailSettingsOptions)
		{
			_smtpClient = new SmtpClient();
			this.emailRepository = emailRepository;
			this.jSRuntime = jSRuntime;
			emailSettingsOptions = EmailSettingsOptions;
		}

		public async Task SendEmailAsync(MimeMessage emailMessage)
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

		public async Task<byte[]> GetPdfBytesAsync()
		{
			var base64String = await jSRuntime.InvokeAsync<string>("getPDFBase64");
			var bytes = Convert.FromBase64String(base64String.Split(',')[1]);

			return bytes;
		}

		public async Task<MimeMessage> CreateEmailMessageAsync(string userEmail)
		{
			var subject = "Kolbs lärstilar - Ditt resultat";
			var emailSettings = emailSettingsOptions.Value;

			var emailMessage = new MimeMessage();
			emailMessage.From.Add(new MailboxAddress(emailSettings.SenderName, emailSettings.Sender));
			emailMessage.To.Add(new MailboxAddress("", userEmail));
			emailMessage.Subject = subject;

			var multipart = new Multipart("mixed");
			var textPart = new TextPart("plain") { Text = "Ditt resultat finns bifogat som PDF." };
			multipart.Add(textPart);

			var pdfAttachment = new MimePart("application", "pdf")
			{
				Content = new MimeContent(new MemoryStream(await GetPdfBytesAsync()), ContentEncoding.Default),
				ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
				ContentTransferEncoding = ContentEncoding.Base64,
				FileName = "TestResults.pdf"
			};

			multipart.Add(pdfAttachment);

			emailMessage.Body = multipart;

			return emailMessage;
		}
	}
}
