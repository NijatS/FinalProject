using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Miles.Core.Entities;
using Miles.Data.Context;
using Miles.Service.Dtos.Categories;
using Miles.Service.Dtos.Features;
using Miles.Service.Services.Interfaces;
using System.Security.Claims;

namespace Miles.App.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class FeatureController : Controller
    {
        private readonly IFeatureService _service;
        private readonly IUserPricingService _userPricingService;
        private readonly ILogger<FeatureController> _logger;

        public FeatureController(IFeatureService service, ILogger<FeatureController> logger, IUserPricingService userPricingService)
        {
            _service = service;
            _logger = logger;
            _userPricingService = userPricingService;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            var result = await _service.GetAllAsync(0, 0);
            int TotalCount = ((IEnumerable<Feature>)result.items).Count();
            ViewBag.TotalPage = (int)Math.Ceiling((decimal)TotalCount / 8);
            ViewBag.CurrentPage = page;
            int count = 8;
            result = await _service.GetAllAsync(count,page);
            return View(result.items);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var result = await _userPricingService.GetAllAsync(0,0);
			ViewBag.UserPricings = result.items;
			return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FeaturePostDto dto)
        {
            var result = await _userPricingService.GetAllAsync(0, 0);
            ViewBag.UserPricings = result.items;

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
            _logger.LogInformation("Feature Created by " + User.FindFirstValue(ClaimTypes.NameIdentifier));

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var result = await _userPricingService.GetAllAsync(0, 0);
            ViewBag.UserPricings = result.items;

             result = await _service.GetAsync(id);
            if (result.StatusCode == 404)
            {
                return NotFound();
            }
            return View(result.items);
        }
        public async Task<IActionResult> Update(int id,FeatureUpdateDto dto)
        {
            var result = await _userPricingService.GetAllAsync(0, 0);
            ViewBag.UserPricings = result.items;

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
            _logger.LogInformation("Feature Updated by " + User.FindFirstValue(ClaimTypes.NameIdentifier));
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Remove(int id)
        {
            var result = await _service.RemoveAsync(id);
            if(result.StatusCode == 404)
            {
                return NotFound();
            }
            _logger.LogInformation("Feature Removed by " + User.FindFirstValue(ClaimTypes.NameIdentifier));
            return RedirectToAction(nameof(Index));
        }
    }
}
