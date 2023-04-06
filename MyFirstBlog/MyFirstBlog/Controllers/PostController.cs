using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyFirstBlog.Models;

namespace MyFirstBlog.Controllers
{
    public class PostController : Controller
    {
        private readonly ILogger<PostController> _logger;

        public PostController(ILogger<PostController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            using var ctx = new BlogContext();
            var posts = ctx.Posts.ToArray();

            return View(posts);
        }

        public IActionResult Detail(int id)
        {
            using var ctx = new BlogContext();
            var post = ctx.Posts.SingleOrDefault(p => p.Id == id);
            
            if (post is null)
            {
                return NotFound($"Post with id {id} not found.");
            }

            return View(post);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}