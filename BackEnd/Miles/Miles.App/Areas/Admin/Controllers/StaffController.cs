using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Miles.Core.Entities;
using Miles.Data.Context;
using Miles.Service.Dtos.Staffs;
using Miles.Service.Services.Interfaces;
using System.Security.Claims;

namespace Miles.App.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class StaffController : Controller
    {
        private readonly IStaffService _service;
        private readonly IPositionService _positionService;
        private readonly ILogger<StaffController> _logger;
        private readonly ISocialService _socialService;
        public StaffController(IStaffService service, ILogger<StaffController> logger, IPositionService positionService, ISocialService socialService)
        {
            _service = service;
            _logger = logger;
            _positionService = positionService;
            _socialService = socialService;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            var result = await _service.GetAllAsync(0, 0);
            int TotalCount = ((IEnumerable<Staff>)result.items).Count();
            ViewBag.TotalPage = (int)Math.Ceiling((decimal)TotalCount / 4);
            ViewBag.CurrentPage = page;
            int count = 8;
            result = await _service.GetAllAsync(count,page);
            return View(result.items);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var result = await _positionService.GetAllAsync(0,0);
			ViewBag.Positions = result.items;
			return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StaffPostDto dto)
        {
            var result = await _positionService.GetAllAsync(0, 0);
            ViewBag.Positions = result.items;

            if (!ModelState.IsValid)
            {
                return View(dto);
            }
             result = await _service.CreateAsync(dto);
            if (result.StatusCode == 400)
            {
                ModelState.AddModelError("", result.Description);
                return View(dto);
            }
            _logger.LogInformation("Staff Created by " + User.FindFirstValue(ClaimTypes.NameIdentifier));
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var result = await _positionService.GetAllAsync(0, 0);
            ViewBag.Positions = result.items;

             result = await _service.GetAsync(id);
            if (result.StatusCode == 404)
            {
                return NotFound();
            }
            return View(result.items);
        }
        public async Task<IActionResult> Update(int id,StaffUpdateDto dto)
        {
            var result = await _positionService.GetAllAsync(0, 0);
            ViewBag.Positions = result.items;

            if (!ModelState.IsValid)
            {
                return View(dto);
            }
             result = await _service.UpdateAsync(id,dto);
            if (result.StatusCode == 400)
            {
                ModelState.AddModelError("", result.Description);
                return View(dto);
            }
            _logger.LogInformation("Staff Updated by " + User.FindFirstValue(ClaimTypes.NameIdentifier));
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Remove(int id)
        {
            var result = await _service.RemoveAsync(id);
            if(result.StatusCode == 404)
            {
                return NotFound();
            }
            _logger.LogInformation("Staff Removed by " + User.FindFirstValue(ClaimTypes.NameIdentifier));
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Social(int id)
        {
            var result = await _socialService.GetAllAsync(0, 0);
            IEnumerable<Social> socials =((IEnumerable<Social>)result.items).Where(x=>!x.IsDeleted && x.StaffId==id);
            return View(socials);
        }
    }
}
