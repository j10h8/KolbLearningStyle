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

		public bool CheckInput(InputModel input)
		{
			if (input.Input11 == 0 || input.Input11 + input.Input12 + input.Input13 + input.Input14 != 10 || input.Input21 + input.Input22 + input.Input23 + input.Input24 != 10 || input.Input31 + input.Input32 + input.Input33 + input.Input34 != 10 || input.Input41 + input.Input42 + input.Input43 + input.Input44 != 10 || input.Input51 + input.Input52 + input.Input53 + input.Input54 != 10 || input.Input61 + input.Input62 + input.Input63 + input.Input64 != 10 || input.Input71 + input.Input72 + input.Input73 + input.Input74 != 10 || input.Input81 + input.Input82 + input.Input83 + input.Input84 != 10 || input.Input91 + input.Input92 + input.Input93 + input.Input94 != 10)
			{
				return false;
			}

			return true;
		}

		public async Task<List<ResultModel>> GetResultsAsync()
		{
			return await resultRepository.GetResultsAsync();
		}

		//Räkna ut ResultModel från InputModel
		public ResultModel GetResultFromInput(InputModel input)
		{
			ResultModel result = new();
			result.IdeaGiver = Add(new int[] { input.Input21, input.Input31, input.Input41, input.Input51, input.Input61, input.Input81, input.Input91 });
			result.Explainer = Add(new int[] { input.Input12, input.Input22, input.Input32, input.Input62, input.Input72, input.Input82, input.Input92 });
			result.Gatherer = Add(new int[] { input.Input13, input.Input23, input.Input33, input.Input43, input.Input53, input.Input63, input.Input93 });
			result.Tester = Add(new int[] { input.Input14, input.Input34, input.Input44, input.Input64, input.Input74, input.Input84, input.Input94 });
			return result;
		}

		// Lägg ihop alla numbers i array
		public int Add(int[] numbers)
		{
			int sum = 0;
			foreach (int number in numbers)
			{
				sum += number;
			}
			return sum;
		}
	}
}
