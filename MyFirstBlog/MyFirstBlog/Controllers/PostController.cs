using Microsoft.AspNetCore.Mvc;

namespace MyFirstBlog.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
