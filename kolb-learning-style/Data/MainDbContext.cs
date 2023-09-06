using kolb_learning_style.Models;
using Microsoft.EntityFrameworkCore;

namespace kolb_learning_style.Data
{
	public class MainDbContext : DbContext
	{
		public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
		{

		}

		public DbSet<ResultModel> Results { get; set; }

		public DbSet<EmailAddressModel> SendList { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			Random random = new Random();

			List<ResultModel> resultModels = new List<ResultModel>();

			for (int i = 1; i <= 50; i++)
			{
				ResultModel resultModel = new ResultModel
				{
					ResultId = i,
					Tester = random.Next(5, 21),       // Random value between 5 and 25
					IdeaGiver = random.Next(5, 21),   // Random value between 5 and 25
					Gatherer = random.Next(5, 21),    // Random value between 5 and 25
					Explainer = random.Next(5, 21)    // Random value between 5 and 25
				};

				resultModels.Add(resultModel);
			}

			modelBuilder.Entity<ResultModel>().HasData(resultModels);
		}

	}
}
