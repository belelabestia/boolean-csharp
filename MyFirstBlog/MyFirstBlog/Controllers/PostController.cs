using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyFirstBlog.Models;

namespace MyFirstBlog.Controllers
{
    public class PostController : Controller
    {
        private readonly ILogger<PostController> _logger;
        private readonly BlogContext _context;

		public PostController(ILogger<PostController> logger, BlogContext context)
		{
			_logger = logger;
			_context = context;
		}

		public IActionResult Index()
        {
            var posts = _context.Posts.ToArray();
            return View(posts);
        }

        public IActionResult Detail(int id)
        {
            var post = _context.Posts.SingleOrDefault(p => p.Id == id);
            
            if (post is null)
            {
                return View("NotFound", "Post not found.");
            }

            return View(post);
        }

        public IActionResult Create()
        {
            var post = new Post
            {
                ImageSrc = "https://picsum.photos/200/300"
			};

            return View(post);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Post post)
        {
            if (!ModelState.IsValid)
            {
                return View(post);
            }
            
            _context.Posts.Add(post);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}