﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Miles.Data.Context;
using Miles.Service.Dtos.Categories;
using Miles.Service.Dtos.Models;
using Miles.Service.Services.Interfaces;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Miles.App.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ModelController : Controller
    {
        private readonly MilesAppDbContext _context;
        private readonly IModelService _service;
        private readonly IBrandService _brandService;
		public ModelController(IModelService service, IBrandService brandService, MilesAppDbContext context)
		{
			_service = service;
			_brandService = brandService;
			_context = context;
		}

		public async Task<IActionResult> Index(int page = 1)
        {
            int TotalCount = _context.Models.Where(x => !x.IsDeleted).Count();
            ViewBag.TotalPage = (int)Math.Ceiling((decimal)TotalCount / 4);
            ViewBag.CurrentPage = page;
            int count = 4;
           var result = await _service.GetAllAsync(count,page);
            return View(result.items);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var result = await _brandService.GetAllAsync(0, 0);
			ViewBag.Brands = result.items;
			return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ModelPostDto dto)
        {
            var result = await _brandService.GetAllAsync(0, 0);
            ViewBag.Brands = result.items;

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
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var result = await _brandService.GetAllAsync(0, 0);
            ViewBag.Brands = result.items;

            result = await _service.GetAsync(id);
            if (result.StatusCode == 404)
            {
                return NotFound();
            }
            return View(result.items);
        }
        public async Task<IActionResult> Update(int id,ModelUpdateDto dto)
        {
            var result = await _brandService.GetAllAsync(0, 0);
            ViewBag.Brands = result.items;

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