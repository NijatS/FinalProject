using Microsoft.AspNetCore.Mvc;

namespace Miles.App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}