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

		public DbSet<QuestionModel> Questions { get; set; }
	}
}
