using Microsoft.AspNetCore.Mvc;

namespace MyFirstBlog.Controllers
{
	public class RazorExampleController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
