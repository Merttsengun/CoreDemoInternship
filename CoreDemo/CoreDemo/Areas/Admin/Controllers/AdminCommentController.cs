using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("admin")]
    public class AdminCommentController : Controller
    {
        CommentManager commentManager= new CommentManager(new EfCommentRepository());  
        public IActionResult Index()
        {
			var username = User.Identity.Name;
			ViewBag.Name = username;
			var values = commentManager.GetCommentWithBlog();
            return View(values);
        }
    }
}
