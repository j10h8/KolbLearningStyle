using kolb_learning_style.Data;
using kolb_learning_style.Repositories;
using kolb_learning_style.Services;
using Microsoft.EntityFrameworkCore;

namespace KolbLearningStyleUnitTests
{
	[TestClass]
	public class UnitTests
	{
		ResultService resultService;

		public UnitTests()
		{
			this.resultService = new ResultService(new ResultRepository(new MainDbContext(new DbContextOptions<MainDbContext>())));
		}

		[TestMethod]
		public void TestGetResultFromInput()
		{
			// Arrange
			InputModel inputModel = new InputModel()
			{
				Input11 = 2,
				Input12 = 4,
				Input13 = 1,
				Input14 = 3,

				Input21 = 1,
				Input22 = 2,
				Input23 = 4,
				Input24 = 3,

				Input31 = 2,
				Input32 = 1,
				Input33 = 4,
				Input34 = 3,

				Input41 = 2,
				Input42 = 4,
				Input43 = 1,
				Input44 = 3,

				Input51 = 1,
				Input52 = 2,
				Input53 = 3,
				Input54 = 4,

				Input61 = 3,
				Input62 = 1,
				Input63 = 4,
				Input64 = 2,

				Input71 = 4,
				Input72 = 3,
				Input73 = 2,
				Input74 = 1,

				Input81 = 2,
				Input82 = 4,
				Input83 = 1,
				Input84 = 3,

				Input91 = 4,
				Input92 = 1,
				Input93 = 2,
				Input94 = 3
			};

			// Act
			ResultModel resultModel = resultService.GetResultFromInput(inputModel);

			Assert.AreEqual(18, resultModel.Tester);
			Assert.AreEqual(15, resultModel.IdeaGiver);
			Assert.AreEqual(19, resultModel.Gatherer);
			Assert.AreEqual(16, resultModel.Explainer);
		}
	}
}