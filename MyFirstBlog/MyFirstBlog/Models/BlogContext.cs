using Microsoft.EntityFrameworkCore;

namespace MyFirstBlog.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public void Seed()
        {
            var postSeed = new Post[]
            {
                new()
                {
                    ImageUrl = "https://picsum.photos/id/10/200/300",
                    Title =  "Post title",
                    Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Mollitia quis est adipisci incidunt rem nostrum ipsam fuga ratione tempora eveniet!"
                },
                new()
                {
                    ImageUrl = "/img/fondo-pag-speciali.jpg",
                    Title = "Post title 1",
                    Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Mollitia quis est adipisci incidunt rem nostrum ipsam fuga ratione tempora eveniet!"
                }
            };

            if (!Posts.Any())
            {
                Posts.AddRange(postSeed);
            }

            if (!Categories.Any())
            {
                var seed = new Category[]
                {
                    new()
                    {
                        Title = "Fun",
                    },
                    new()
                    {
                        Title = "Generic",
                        Posts = postSeed
                    }
                };

                Categories.AddRange(seed);
            }

            if (!Tags.Any())
            {
                var seed = new Tag[]
                {
                    new()
                    {
                        Title = "foryou"
                    },
                    new()
                    {
                        Title = "lifestyle",
                        Posts = postSeed
                    },
                    new()
                    {
                        Title = "science"
                    }
                };

                Tags.AddRange(seed);
            }

            SaveChanges();
        }
    }
}
