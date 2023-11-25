using Microsoft.AspNetCore.Mvc;

namespace Restaurant.WebUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
