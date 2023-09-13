using kolb_learning_style.Data;
using kolb_learning_style.Models;

namespace kolb_learning_style.Repositories
{
    public class EmailRepository : IEmailRepository
    {
        private readonly MainDbContext mainDbContext;

        public EmailRepository(MainDbContext mainDbContext)
        {
            this.mainDbContext = mainDbContext;
        }

        public async Task<bool> AddEmailAddressAsync(string emailAddress)
        {
            if (!string.IsNullOrWhiteSpace(emailAddress))
            {
                // Save the email to the database
                mainDbContext.SendList.Add(new EmailAddressModel { EmailAddress = emailAddress });

                if (await mainDbContext.SaveChangesAsync() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }
    }
}
