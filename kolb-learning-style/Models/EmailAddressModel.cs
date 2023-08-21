using System.ComponentModel.DataAnnotations;

namespace kolb_learning_style.Models
{
	public class EmailAddressModel
	{
		[Key]
		public int Id { get; set; }
		public string EmailAddress { get; set; } = null!;
	}
}
