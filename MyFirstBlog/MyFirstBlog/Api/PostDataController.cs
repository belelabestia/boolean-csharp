using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFirstBlog.Models;

namespace MyFirstBlog.Api
{
    [Route("api/")]
    [ApiController]
    public class PostDataController : ControllerBase
    {
        private readonly BlogContext _context;

        public PostDataController(BlogContext context)
        {
            _context = context;
        }

        [Route("category")]
        [HttpGet]
        public IActionResult GetCategories()
        {
            return Ok(_context.Categories.ToList());
        }

        [Route("tag")]
        [HttpGet]
        public IActionResult GetTags()
        {
            return Ok(_context.Tags.ToList());
        }
    }
}
