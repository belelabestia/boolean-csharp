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
                ImageUrl = "https://picsum.photos/200/300"
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

            post.SetImageFileFromFormFile();
            
            _context.Posts.Add(post);
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

            return View(post);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, Post post)
        {
            if (!ModelState.IsValid)
            {
                return View(post);
            }

            // ---ORIGINAL---

            //var postToUpdate = _context.Posts.FirstOrDefault(p => p.Id == id);

            //if (postToUpdate is null)
            //{
            //    return View("NotFound");
            //}

            //postToUpdate.Title = post.Title;
            //postToUpdate.Description = post.Description;
            //postToUpdate.ImageUrl = post.ImageUrl;

            //_context.SaveChanges();

            // ---FANCY---

            var savedPost = _context.Posts.AsNoTracking().FirstOrDefault(p => p.Id == id);

            if (savedPost is null)
            {
                return View("NotFound");
            }

            post.ImageFile = savedPost.ImageFile;
            post.SetImageFileFromFormFile();

            _context.Posts.Update(post);
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