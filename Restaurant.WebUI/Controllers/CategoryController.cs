using Microsoft.AspNetCore.Mvc;

namespace Restaurant.WebUI.Controllers
{
	public class CategoryController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
