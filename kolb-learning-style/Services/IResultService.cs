using kolb_learning_style.Models;

namespace kolb_learning_style.Services
{
    public interface IResultService
    {
        Task<bool> AddResultAsync(ResultModel result);
        Task<List<ResultModel>> GetResultsAsync();
    }
}