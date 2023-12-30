using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Via.MVC.Models;

namespace Via.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Anasayfa()
        {
            return View();
        }
    }
}