using Microsoft.EntityFrameworkCore;

namespace MyFirstBlog.Models
{
    public class BlogContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=BlogDb;Integrated Security=True;Pooling=False;TrustServerCertificate=True");
        }

        public void Seed()
        {
            if (!Posts.Any())
            {
                var seed = new Post[]
                {
                    new Post
                    {
                        ImageSrc = "https://picsum.photos/id/10/200/300",
                        Title =  "Post title",
                        Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Mollitia quis est adipisci incidunt rem nostrum ipsam fuga ratione tempora eveniet!"
                    },
                    new Post
                    {
                        ImageSrc = "/img/fondo-pag-speciali.jpg",
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
