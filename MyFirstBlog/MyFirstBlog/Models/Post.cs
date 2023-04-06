namespace MyFirstBlog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string ImageSrc { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
