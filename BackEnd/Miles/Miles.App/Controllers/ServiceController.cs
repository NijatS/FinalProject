using Microsoft.AspNetCore.Mvc;

namespace Miles.App.Controllers
{
	public class ServiceController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
