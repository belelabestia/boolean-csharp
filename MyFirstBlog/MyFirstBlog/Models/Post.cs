using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MyFirstBlog.Attributes;

namespace MyFirstBlog.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Plase provide a post Title.")]
        [StringLength(100, ErrorMessage = "Title must have less than 100 characters.")]
        [MoreThanNWords(4)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Plase provide a post Description.")]
        [Column(TypeName = "text")]
        public string Description { get; set; } = string.Empty;

        public string? ImageSrc { get; set; }
    }
}
