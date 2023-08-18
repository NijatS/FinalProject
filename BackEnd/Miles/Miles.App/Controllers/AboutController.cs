using Microsoft.AspNetCore.Mvc;
using Miles.Service.Services.Interfaces;
using Miles.Service.ViewModels;

namespace Miles.App.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutTextService 
            _aboutTextService;
        public async Task<IActionResult> Index()
        {
           AboutVM aboutVM = new AboutVM
           {
               AboutText = 
           }
        }
    }
}
