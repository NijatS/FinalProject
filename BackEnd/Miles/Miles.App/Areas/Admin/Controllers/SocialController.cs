using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Miles.Data.Context;
using Miles.Service.Dtos.Categories;
using Miles.Service.Dtos.Socials;
using Miles.Service.Services.Interfaces;

namespace Miles.App.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialController : Controller
    {
        private readonly MilesAppDbContext _context;
        private readonly ISocialService _service;

        public SocialController(MilesAppDbContext context, ISocialService service)
        {
            _context = context;
            _service = service;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            int TotalCount = _context.Socials.Where(x => !x.IsDeleted).Count();
            ViewBag.TotalPage = (int)Math.Ceiling((decimal)TotalCount / 4);
            ViewBag.CurrentPage = page;
            int count = 8;
            var result = await _service.GetAllAsync(count,page);
            return View(result.items);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
			ViewBag.Staffs = await _context.Staffs.Where(x => !x.IsDeleted).ToListAsync();
			return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SocialPostDto dto)
        {
			ViewBag.Staffs = await _context.Staffs.Where(x => !x.IsDeleted).ToListAsync();

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
			ViewBag.Staffs = await _context.Staffs.Where(x => !x.IsDeleted).ToListAsync();

			var result = await _service.GetAsync(id);
            if (result.StatusCode == 404)
            {
                return NotFound();
            }
            return View(result.items);
        }
        public async Task<IActionResult> Update(int id,SocialUpdateDto dto)
        {
			ViewBag.Staffs = await _context.Staffs.Where(x => !x.IsDeleted).ToListAsync();

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
