using Microsoft.AspNetCore.Mvc;

namespace MyFirstBlog.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
