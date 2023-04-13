using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Extensions.Hosting;
using MyFirstBlog.Attributes;

namespace MyFirstBlog.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Plase provide a post Title.")]
        [StringLength(100, ErrorMessage = "Title must have less than 100 characters.")]
        [MoreThanNWords(2)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Plase provide a post Description.")]
        [Column(TypeName = "text")]
        public string Description { get; set; } = string.Empty;

        public decimal Rating { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        public byte[]? ImageFile { get; set; }

        public string ImgSrc => ImageFile is null
            ? ImageUrl
            : $"data:image/png;base64,{Convert.ToBase64String(ImageFile)}";

        [NonZero(ErrorMessage = "Please pick a category.")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}