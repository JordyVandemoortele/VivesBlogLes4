using System.ComponentModel.DataAnnotations;

namespace VivesBlog.Ui.Mvc.Models
{
    public class Article
    {
        public int Id { get; set; }

        [Required]
        public required string Title { get; set; }
        [Required]
        public required string Description { get; set; }
        [Required]
        public required string Content { get; set; }
        [Required]
        public required string Author { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
