namespace MyFirstBlog.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        public IEnumerable<Post>? Posts { get; set; }
    }
}
