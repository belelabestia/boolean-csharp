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

        public string ImageUrl { get; set; } = string.Empty;

        public byte[]? ImageFile { get; set; }

        [NotMapped]
        public IFormFile? ImageFormFile { get; set; }

        public string ImgSrc => ImageFile is null
            ? ImageUrl
            : $"data:image/png;base64,{Convert.ToBase64String(ImageFile)}";

        public void SetImageFileFromFormFile()
        {
            if (ImageFormFile is null) return;

            using var stream = new MemoryStream();
            ImageFormFile!.CopyTo(stream);
            ImageFile = stream.ToArray();
        }
    }
}