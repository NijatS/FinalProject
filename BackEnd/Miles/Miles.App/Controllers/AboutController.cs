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
        private readonly IAssociateService _associateService;
        private readonly ICommentService _commentService;

        public AboutController(IAboutTextService aboutTextService, IAboutSkillService aboutSkillService, IStaffService staffService, IAssociateService associateService, ICommentService commentService)
        {
            _aboutTextService = aboutTextService;
            _aboutSkillService = aboutSkillService;
            _staffService = staffService;
            _associateService = associateService;
            _commentService = commentService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.IsDataLoading = true;
            var aboutTextResult = await _aboutTextService.GetAsync(null);
            var aboutSkillResult = await _aboutSkillService.GetAllAsync(0,0);
            var staffResult = await _staffService.GetAllAsync(0, 0);
            var resultAssociate = await _associateService.GetAllAsync(0, 0);
            var commentResult = await _commentService.GetAllAsync(0, 0,null);

            AboutVM aboutVM = new AboutVM
            {
                AboutText = (AboutText)aboutTextResult.itemView,
                AboutSkills = (IEnumerable<AboutSkill>)aboutSkillResult.items,
                Staffs = (IEnumerable<Staff>)staffResult.items,
                Associates = (IEnumerable<Associate>)resultAssociate.items,
                Comments = (IEnumerable<Comment>)commentResult.items,
            };
            ViewBag.IsDataLoading = false;
            return View(aboutVM);
        }
    }
}
