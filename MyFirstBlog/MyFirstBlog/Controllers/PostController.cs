using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyFirstBlog.Models;

namespace MyFirstBlog.Controllers
{
	[Authorize(Roles = "Admin,User")]
	public class PostController : Controller
	{
		private readonly BlogContext _context;

		public PostController(BlogContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var posts = _context.Posts
				.Include(p => p.Category)
				.ToArray();

			return View(posts);
		}

		public IActionResult ApiIndex()
		{
			return View();
		}

        public IActionResult ApiCreate()
        {
            return View();
        }

        public IActionResult ApiEdit()
        {
            return View();
        }

        public IActionResult Detail(int id)
		{
			var post = _context.Posts
				.Include(p => p.Category)
				.Include(p => p.Tags)
				.SingleOrDefault(p => p.Id == id);

			if (post is null)
			{
				return View("NotFound", "Post not found.");
			}

			return View(post);
		}

		[Authorize(Roles = "Admin")]
		public IActionResult Create()
		{
			var formModel = new PostFormModel
			{
				Categories = _context.Categories.ToArray(),
				Tags = _context.Tags.ToArray(),
			};

			return View(formModel);
		}

		[Authorize(Roles = "Admin")]
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(PostFormModel form)
		{
			if (!ModelState.IsValid)
			{
				form.Categories = _context.Categories.ToArray();
				form.Tags = _context.Tags.ToArray();

				return View(form);
			}

			form.Post.Tags = _context.Tags.Where(t => form.SelectedTagIds.Contains(t.Id)).ToList();

			form.SetImageFileFromFormFile();

			_context.Posts.Add(form.Post);
			_context.SaveChanges();

			return RedirectToAction("Index");
		}

		[Authorize(Roles = "Admin")]
		public IActionResult Update(int id)
		{
			var post = _context.Posts.Include(p => p.Tags).FirstOrDefault(p => p.Id == id);

			if (post is null)
			{
				return View("NotFound");
			}

			var formModel = new PostFormModel
			{
				Post = post,
				Categories = _context.Categories.ToArray(),
				Tags = _context.Tags.ToArray(),
				SelectedTagIds = post.Tags!.Select(t => t.Id).ToList()
			};

			return View(formModel);
		}

		[Authorize(Roles = "Admin")]
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Update(int id, PostFormModel form)
		{
			if (!ModelState.IsValid)
			{
				form.Categories = _context.Categories.ToArray();
				form.Tags = _context.Tags.ToArray();

				return View(form);
			}

			var savedPost = _context.Posts.Include(p => p.Tags).FirstOrDefault(p => p.Id == id);

			if (savedPost is null)
			{
				return View("NotFound");
			}

			form.SetImageFileFromFormFile();

			savedPost.Title = form.Post.Title;
			savedPost.Description = form.Post.Description;
			savedPost.ImageUrl = form.Post.ImageUrl;
			savedPost.CategoryId = form.Post.CategoryId;
			savedPost.ImageFile = form.Post.ImageFile;
			savedPost.Tags = _context.Tags.Where(t => form.SelectedTagIds.Contains(t.Id)).ToList();

            _context.SaveChanges();

			return RedirectToAction("Index");
		}

		[Authorize(Roles = "Admin")]
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