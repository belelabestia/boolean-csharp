using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyFirstBlog.Models
{
    public class PostFormModel
    {
        public Post Post { get; set; } = new Post { ImageUrl = "https://picsum.photos/200/300" };
        public IFormFile? ImageFormFile { get; set; }
        public IEnumerable<Category> Categories { get; set; } = Enumerable.Empty<Category>();
        
        public IEnumerable<SelectListItem> Tags { get; set; } = Enumerable.Empty<SelectListItem>();
        public List<string> SelectedTags { get; set; } = new();

        public void SetImageFileFromFormFile()
        {
            if (ImageFormFile is null) return;

            using var stream = new MemoryStream();
            ImageFormFile!.CopyTo(stream);
            Post.ImageFile = stream.ToArray();
        }
    }
}
