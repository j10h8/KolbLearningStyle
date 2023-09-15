namespace kolb_learning_style.Repositories
{
    public interface IEmailRepository
    {
        Task<bool> AddEmailAddressAsync(string emailAddress);
    }
}
