using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MiniBookShop.Models;

namespace MiniBookShop.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
