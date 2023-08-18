using System.ComponentModel.DataAnnotations;

namespace kolb_learning_style.Models
{
	public class QuestionModel
	{
		[Key]
		public int QuestionId { get; set; }
		public string? Alternative_1 { get; set; }
		public string? Alternative_2 { get; set; }
		public string? Alternative_3 { get; set; }
		public string? Alternative_4 { get; set; }

	}
}
