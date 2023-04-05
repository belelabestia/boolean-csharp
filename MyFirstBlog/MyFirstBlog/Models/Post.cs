using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace MyFirstBlog.Models
{
    public class Post
    {
        public Post(string imageSrc, string title, string description)
        {
            ImageSrc = imageSrc;
            Title = title;
            Description = description;
        }

        public string ImageSrc { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
