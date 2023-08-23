using kolb_learning_style.Models;

namespace kolb_learning_style.Repositories
{
	public interface IResultRepository
	{
		Task<bool> AddResultAsync(ResultModel result);
	}
}