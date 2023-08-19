using Microsoft.AspNetCore.Mvc;
using Miles.Core.Entities;
using Miles.Service.Services.Interfaces;
using Miles.Service.ViewModels;

namespace Miles.App.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutTextService _aboutTextService;
        private readonly IAboutSkillService _aboutSkillService;
        private readonly IStaffService  _staffService;

        public AboutController(IAboutTextService aboutTextService, IAboutSkillService aboutSkillService, IStaffService staffService)
        {
            _aboutTextService = aboutTextService;
            _aboutSkillService = aboutSkillService;
            _staffService = staffService;
        }

        public async Task<IActionResult> Index()
        {
           var aboutTextResult = await _aboutTextService.GetAsync(null);
            var aboutSkillResult = await _aboutSkillService.GetAllAsync(0,0);
            var staffResult = await _staffService.GetAllAsync(0, 0);
            AboutVM aboutVM = new AboutVM
            {
                AboutText = (AboutText)aboutTextResult.itemView,
                AboutSkills = (IEnumerable<AboutSkill>)aboutSkillResult.items,
                Staffs = (IEnumerable<Staff>)staffResult.items,
            };
            return View(aboutVM);
        }
    }
}
