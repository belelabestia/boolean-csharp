using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyFirstBlog.Models
{
    public class BlogContext : IdentityDbContext<IdentityUser>
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

            if (!Roles.Any())
            {
                var seed = new IdentityRole[]
                {
                    new("Admin"),
                    new("User")
                };

                Roles.AddRange(seed);
            }

            if (Users.Any(u => u.Email == "admin@dev.com" || u.Email == "user@dev.com")
                && !UserRoles.Any())
            {
                var admin = Users.First(u => u.Email == "admin@dev.com");
                var user = Users.First(u => u.Email == "user@dev.com");

                var adminRole = Roles.First(r => r.Name == "Admin");
                var userRole = Roles.First(r => r.Name == "User");

                var seed = new IdentityUserRole<string>[]
                {
                    new()
                    {
                        UserId = admin.Id,
                        RoleId = adminRole.Id
                    },
                    new()
                    {
                        UserId = user.Id,
                        RoleId = userRole.Id
                    }
                };

                UserRoles.AddRange(seed);
            }

            SaveChanges();
        }
    }
}
