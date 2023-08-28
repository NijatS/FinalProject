using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Miles.Data.Context;
using Miles.Service.Dtos.Categories;
using Miles.Service.Dtos.Features;
using Miles.Service.Services.Interfaces;

namespace Miles.App.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class FeatureController : Controller
    {
        private readonly MilesAppDbContext _context;
        private readonly IFeatureService _service;

        public FeatureController(MilesAppDbContext context, IFeatureService service)
        {
            _context = context;
            _service = service;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            int TotalCount = _context.Features.Where(x => !x.IsDeleted).Count();
            ViewBag.TotalPage = (int)Math.Ceiling((decimal)TotalCount / 8);
            ViewBag.CurrentPage = page;
            int count = 8;
            var result = await _service.GetAllAsync(count,page);
            return View(result.items);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
			ViewBag.UserPricings = await _context.UserPricings.Where(x => !x.IsDeleted).ToListAsync();
			return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FeaturePostDto dto)
        {
			ViewBag.UserPricings = await _context.UserPricings.Where(x => !x.IsDeleted).ToListAsync();

			if (!ModelState.IsValid)
            {
                return View(dto);
            }
            var result = await _service.CreateAsync(dto);
            if (result.StatusCode == 400)
            {
                ModelState.AddModelError("", result.Description);
                return View(dto);
            }
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
			ViewBag.UserPricings = await _context.UserPricings.Where(x => !x.IsDeleted).ToListAsync();

			var result = await _service.GetAsync(id);
            if (result.StatusCode == 404)
            {
                return NotFound();
            }
            return View(result.items);
        }
        public async Task<IActionResult> Update(int id,FeatureUpdateDto dto)
        {
			ViewBag.UserPricings = await _context.UserPricings.Where(x => !x.IsDeleted).ToListAsync();

			if (!ModelState.IsValid)
            {
                return View(dto);
            }
            var result = await _service.UpdateAsync(id,dto);
            if (result.StatusCode == 400)
            {
                ModelState.AddModelError("", result.Description);
                return View(dto);
            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Remove(int id)
        {
            var result = await _service.RemoveAsync(id);
            if(result.StatusCode == 404)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
