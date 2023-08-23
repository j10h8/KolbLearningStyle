using kolb_learning_style.Models;
using kolb_learning_style.Repositories;

namespace kolb_learning_style.Services
{
	public class ResultService : IResultService
	{
		private readonly IResultRepository resultRepository;

		public ResultService(IResultRepository resultRepository)
		{
			this.resultRepository = resultRepository;
		}

		public async Task<bool> AddResultAsync(ResultModel result)
		{
			return await resultRepository.AddResultAsync(result);
		}
	}
}
