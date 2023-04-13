namespace MyFirstBlog.Models
{
    public class PostFormModel
    {
        public Post Post { get; set; } = new Post { ImageUrl = "https://picsum.photos/200/300" };
        public IEnumerable<Category> Categories { get; set; } = Enumerable.Empty<Category>();
    }
}
