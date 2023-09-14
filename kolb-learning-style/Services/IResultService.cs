using kolb_learning_style.Models;

namespace kolb_learning_style.Services
{
	public interface IResultService
	{
		Task<bool> AddResultAsync(ResultModel result);
		Task<List<ResultModel>> GetResultsAsync();
		bool CheckInput(InputModel input);
		ResultModel GetResultFromInput(InputModel input);
		int Add(int[] numbers);
		ResultModel GetPieChartResult(List<ResultModel> results);
		double[] CalculateProcentData(List<ResultModel> results);
	}
}