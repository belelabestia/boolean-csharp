using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var posts = _context.Posts
                .Include(p => p.Category)
                .ToArray();

            return View(posts);
        }

        public IActionResult Detail(int id)
        {
            var post = _context.Posts
                .Include(p => p.Category)
                .SingleOrDefault(p => p.Id == id);
            
            if (post is null)
            {
                return View("NotFound", "Post not found.");
            }

            return View(post);
        }

        public IActionResult Create()
        {
            var formModel = new PostFormModel
            {
                Categories = _context.Categories.ToArray(),
            };

            return View(formModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PostFormModel form)
        {
            if (!ModelState.IsValid)
            {
                form.Categories = _context.Categories.ToArray();
                return View(form);
            }

            form.Post.SetImageFileFromFormFile();
            
            _context.Posts.Add(form.Post);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var post = _context.Posts.FirstOrDefault(p => p.Id == id);

            if (post is null)
            {
                return View("NotFound");
            }

            var formModel = new PostFormModel
            {
                Post = post,
                Categories = _context.Categories.ToArray()
            };

            return View(formModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, PostFormModel form)
        {
            if (!ModelState.IsValid)
            {
                form.Categories = _context.Categories.ToArray();
                return View(form);
            }

            var savedPost = _context.Posts.AsNoTracking().FirstOrDefault(p => p.Id == id);

            if (savedPost is null)
            {
                return View("NotFound");
            }

            form.Post.ImageFile = savedPost.ImageFile;
            form.Post.SetImageFileFromFormFile();

            _context.Posts.Update(form.Post);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Delete(int id)
        {
            var postToDelete = _context.Posts.FirstOrDefault(p => p.Id == id);

            if (postToDelete is null)
            {
                return View("NotFound");
            }

            _context.Posts.Remove(postToDelete);
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