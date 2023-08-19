using Microsoft.AspNetCore.Mvc;

namespace Miles.App.Controllers
{
    public class ShopController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> Detail()
        {
            return View();
        }
    }
}
