﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private readonly MilesAppDbContext _context;
        private readonly IStaffService _service;
        private readonly ILogger<StaffController> _logger;
        public StaffController(MilesAppDbContext context, IStaffService service, ILogger<StaffController> logger)
        {
            _context = context;
            _service = service;
            _logger = logger;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            int TotalCount = _context.Staffs.Where(x => !x.IsDeleted).Count();
            ViewBag.TotalPage = (int)Math.Ceiling((decimal)TotalCount / 4);
            ViewBag.CurrentPage = page;
            int count = 8;
            var result = await _service.GetAllAsync(count,page);
            return View(result.items);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
			ViewBag.Positions = await _context.Positions.Where(x => !x.IsDeleted).ToListAsync();
			return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StaffPostDto dto)
        {
			ViewBag.Positions = await _context.Positions.Where(x => !x.IsDeleted).ToListAsync();

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
            _logger.LogInformation("Staff Created by " + User.FindFirstValue(ClaimTypes.NameIdentifier));
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
			ViewBag.Positions = await _context.Positions.Where(x => !x.IsDeleted).ToListAsync();

			var result = await _service.GetAsync(id);
            if (result.StatusCode == 404)
            {
                return NotFound();
            }
            return View(result.items);
        }
        public async Task<IActionResult> Update(int id,StaffUpdateDto dto)
        {
			ViewBag.Positions = await _context.Positions.Where(x => !x.IsDeleted).ToListAsync();

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
    }
}
