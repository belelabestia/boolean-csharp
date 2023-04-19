using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFirstBlog.Models;

namespace MyFirstBlog.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly BlogContext _context;

        public PostController(BlogContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetPosts([FromQuery] string? title)
        {
            var posts = _context.Posts
                .Include(p => p.Category)
                .Where(p => title == null || p.Title.ToLower().Contains(title.ToLower()))
                .ToList();

            foreach (var post in posts) post.Category!.Posts = null;

            return Ok(posts);
        }

        [HttpGet("{id}")]
        public IActionResult GetPost(int id)
        {
            var post = _context.Posts.FirstOrDefault(p => p.Id == id);

            if (post is null)
            {
                return NotFound();
            }

            return Ok(post);
        }

        [HttpPost]
        public IActionResult CreatePost(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();

            return Ok(post);
        }

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
