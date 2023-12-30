using Microsoft.AspNetCore.Mvc;

namespace Via.MVC.Controllers
{
    public class DenemeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
