using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
			var username = User.Identity.Name;
			ViewBag.Name = username;
			return View();
        }
    }
}
