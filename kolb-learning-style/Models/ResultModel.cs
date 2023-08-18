using System.ComponentModel.DataAnnotations;

namespace kolb_learning_style.Models
{
    public class ResultModel
    {
        [Key]
        public int ResultId { get; set; }
        public int Tester { get; set }
        public int IdeaGiver { get; set; }
        public int Gatherer { get; set; }
        public int Explainer { get; set; }
    }
}
