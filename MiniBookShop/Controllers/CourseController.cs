using Microsoft.AspNetCore.Mvc;

namespace MiniBookShop.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
