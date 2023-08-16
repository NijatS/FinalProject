using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Miles.Core.Entities;
using Miles.Data.Context;
using Miles.Service.Dtos.Blogs;
using Miles.Service.Services.Interfaces;
using NuGet.Protocol;
using System.Text.Json;

namespace Miles.App.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly MilesAppDbContext _context;
        private readonly IBlogService _service;
        private readonly ICategoryService _categoryService;
        private readonly ITagService _tagService;

        public BlogController(IBlogService service, MilesAppDbContext context, ICategoryService categoryService, ITagService tagService)
        {
            _service = service;
            _context = context;
            _categoryService = categoryService;
            _tagService = tagService;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            int TotalCount = _context.Blogs.Where(x => !x.IsDeleted).Count();
            ViewBag.TotalPage = (int)Math.Ceiling((decimal)TotalCount / 4);
            ViewBag.CurrentPage = page;
            int count = 4;
            var result = await _service.GetAllAsync(count,page);
            return View(result.items);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await _context.Categories.Where(x=>!x.IsDeleted).ToListAsync();
			ViewBag.Tags = await _context.Tags.Where(x => !x.IsDeleted).ToListAsync();
			//ViewBag.Tags = await _tagService.GetAllAsync(0, 0);
			return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BlogPostDto dto)
        {
			ViewBag.Categories = await _context.Categories.Where(x => !x.IsDeleted).ToListAsync();
			ViewBag.Tags = await _context.Tags.Where(x => !x.IsDeleted).ToListAsync();
            if (!ModelState.IsValid)
            {
                return View(dto);
            }
            var result = await _service.CreateAsync(dto);
            if (result.StatusCode == 404)
            {
                ModelState.AddModelError("", result.Description);
                return View(dto);
            }
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
			ViewBag.Categories = await _context.Categories.Where(x => !x.IsDeleted).ToListAsync();
			ViewBag.Tags = await _context.Tags.Where(x => !x.IsDeleted).ToListAsync();
			
            var result = await _service.GetAsync(id);
            if (result.StatusCode == 404)
            {
                return NotFound();
            }
            return View(result.items);
        }
        [HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Update(int id,BlogUpdateDto dto)
        {
			ViewBag.Categories = await _context.Categories.Where(x => !x.IsDeleted).ToListAsync();
			ViewBag.Tags = await _context.Tags.Where(x => !x.IsDeleted).ToListAsync();
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
