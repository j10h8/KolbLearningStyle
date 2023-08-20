using System.ComponentModel.DataAnnotations;

namespace kolb_learning_style.Models
{
	public class InputModel
	{
		[Required(ErrorMessage = "Du måste ange 1, 2, 3 eller 4 i varje fält.")]
		[Range(1, 4)]
		public int Input11 { get; set; }
		[Required(ErrorMessage = "Du måste ange 1, 2, 3 eller 4 i varje fält.")]
		[Range(1, 4)]
		public int Input12 { get; set; }
		[Required(ErrorMessage = "Du måste ange 1, 2, 3 eller 4 i varje fält.")]
		[Range(1, 4)]
		public int Input13 { get; set; }
		[Required(ErrorMessage = "Du måste ange 1, 2, 3 eller 4 i varje fält.")]
		[Range(1, 4)]
		public int Input14 { get; set; }
		[Required(ErrorMessage = "Du måste ange 1, 2, 3 eller 4 i varje fält.")]
		[Range(1, 4)]
		public int Input21 { get; set; }
		// And so on for all 36 inputs. 
	}
}
