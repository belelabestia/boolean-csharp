using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFirstBlog.Logging;
using MyFirstBlog.Models;

namespace MyFirstBlog.Api
{
    // /api/post
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly BlogContext _context;
        private readonly ICustomLogger _logger;

        public PostController(BlogContext context, ICustomLogger logger)
        {
            _context = context;
            _logger = logger;
        }

        // get: /api/post[?title=<...>]
        [HttpGet]
        public IActionResult GetPosts([FromQuery] string? title)
        {
            _logger.WriteLog("Serving posts api data.");

            var posts = _context.Posts
                .Include(p => p.Category)
                .Where(p => title == null || p.Title.ToLower().Contains(title.ToLower()))
                .ToList();

            foreach (var post in posts) post.Category!.Posts = null;

            return Ok(posts);
        }

        // get: /api/post/{id}
        [HttpGet("{id}")]
        public IActionResult GetPost(int id)
        {
            _logger.WriteLog($"Serving post api data (id: {id}).");

            var post = _context.Posts.FirstOrDefault(p => p.Id == id);

            if (post is null)
            {
                return NotFound();
            }

            return Ok(post);
        }

        // post: /api/post (body: post)
        [HttpPost]
        public IActionResult CreatePost(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();

            return Ok(post);
        }

        // put: /api/post/{id} (body: post)
        [HttpPut("{id}")]
        public IActionResult PutPost(int id, [FromBody] Post post)
        {
            var savedPost = _context.Posts.FirstOrDefault(p => p.Id == id);

            if (savedPost is null)
            {
                return NotFound();
            }

            savedPost.Title = post.Title;
            savedPost.Description = post.Description;
            savedPost.ImageUrl = post.ImageUrl;
            savedPost.CategoryId = post.CategoryId;

            _context.SaveChanges();

            return Ok();
        }

        // delete: /api/post/{id}
        [HttpDelete("{id}")]
        public IActionResult DeletePost(int id)
        {
            var savedPost = _context.Posts.FirstOrDefault(p => p.Id == id);

            if (savedPost is null)
            {
                return NotFound();
            }

            _context.Posts.Remove(savedPost);
            _context.SaveChanges();

            return Ok();
        }
    }
}
