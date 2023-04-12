using Microsoft.EntityFrameworkCore;

namespace MyFirstBlog.Models
{
    public class BlogContext : DbContext
    {
		public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }

		public DbSet<Post> Posts { get; set; }

        public void Seed()
        {
            if (!Posts.Any())
            {
                var seed = new Post[]
                {
                    new Post
                    {
                        ImageUrl = "https://picsum.photos/id/10/200/300",
                        Title =  "Post title",
                        Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Mollitia quis est adipisci incidunt rem nostrum ipsam fuga ratione tempora eveniet!"
                    },
                    new Post
                    {
                        ImageUrl = "/img/fondo-pag-speciali.jpg",
                        Title = "Post title 1",
                        Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Mollitia quis est adipisci incidunt rem nostrum ipsam fuga ratione tempora eveniet!"
                    }
                };

                Posts.AddRange(seed);

                SaveChanges();
            }
        }
    }
}
