namespace kolb_learning_style.Services
{
	using MimeKit;
	using System.Threading.Tasks;

	public interface IEmailService
	{
		Task SendEmailAsync(MimeMessage emailMessage);
		Task<bool> AddEmailAddressAsync(string emailAddress);
		Task<MimeMessage> CreateEmailMessageAsync(string userEmail);
		Task<byte[]> GetPdfBytesAsync();
	}
}
