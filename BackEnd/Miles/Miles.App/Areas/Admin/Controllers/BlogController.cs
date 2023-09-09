using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using Miles.Core.Entities;
using Miles.Data.Context;
using Miles.Service.Dtos.Blogs;
using Miles.Service.Services.Interfaces;
using NuGet.Protocol;
using System.Security.Claims;
using System.Text.Json;

namespace Miles.App.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class BlogController : Controller
    {
        private readonly IBlogService _service;
        private readonly ICategoryService _categoryService;
        private readonly ITagService _tagService;
        private readonly ILogger<BlogController> _logger;

        public BlogController(IBlogService service, ICategoryService categoryService, ITagService tagService, ILogger<BlogController> logger)
        {
            _service = service;
            _categoryService = categoryService;
            _tagService = tagService;
            _logger = logger;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            var result = await _service.GetAllAsync(0, 0,x=>!x.IsDeleted);
            int TotalCount = ((IEnumerable<Blog>)result.items).Count();
            ViewBag.TotalPage = (int)Math.Ceiling((decimal)TotalCount / 4);
            ViewBag.CurrentPage = page;
            int count = 4;
            result = await _service.GetAllAsync(count,page, null);
            return View(result.items);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var result = await _categoryService.GetAllAsync(0, 0);
            ViewBag.Categories =(IEnumerable<Category>)result.items;
            result = await _tagService.GetAllAsync(0, 0);
            ViewBag.Tags =  (IEnumerable<Tag>)result.items;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BlogPostDto dto)
        {
            var result = await _categoryService.GetAllAsync(0, 0);
            ViewBag.Categories = (IEnumerable<Category>)result.items;
            result = await _tagService.GetAllAsync(0, 0);
            ViewBag.Tags = (IEnumerable<Tag>)result.items;
            if (!ModelState.IsValid)
            {
                return View(dto);
            }
             result = await _service.CreateAsync(dto);
            if (result.StatusCode == 404)
            {
                ModelState.AddModelError("", result.Description);
                return View(dto);
            }
            _logger.LogInformation("Blog Created by " + User.FindFirstValue(ClaimTypes.NameIdentifier));
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var result = await _categoryService.GetAllAsync(0, 0);
            ViewBag.Categories = (IEnumerable<Category>)result.items;
            result = await _tagService.GetAllAsync(0, 0);
            ViewBag.Tags = (IEnumerable<Tag>)result.items;

            result = await _service.GetAsync(id);
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
            var result = await _categoryService.GetAllAsync(0, 0);
            ViewBag.Categories = (IEnumerable<Category>)result.items;
            result = await _tagService.GetAllAsync(0, 0);
            ViewBag.Tags = (IEnumerable<Tag>)result.items;
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
            _logger.LogInformation("Blog Updated by " + User.FindFirstValue(ClaimTypes.NameIdentifier));
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Remove(int id)
        {
            var result = await _categoryService.GetAllAsync(0, 0);
            ViewBag.Categories = (IEnumerable<Category>)result.items;
            result = await _tagService.GetAllAsync(0, 0);
            ViewBag.Tags = (IEnumerable<Tag>)result.items;
            result = await _service.RemoveAsync(id);
            if(result.StatusCode == 404)
            {
                return NotFound();
            }
            _logger.LogInformation("Blog Removed by " + User.FindFirstValue(ClaimTypes.NameIdentifier));
            return RedirectToAction(nameof(Index));
        }
    }
}
