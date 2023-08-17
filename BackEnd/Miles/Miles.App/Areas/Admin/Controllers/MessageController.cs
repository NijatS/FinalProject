﻿using Microsoft.AspNetCore.Mvc;
using Miles.Data.Context;
using Miles.Service.Dtos.Messages;
using Miles.Service.Services.Interfaces;

namespace Miles.App.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        private readonly IMessageService _service;
        private readonly MilesAppDbContext _context;

        public MessageController(IMessageService service, MilesAppDbContext context)
        {
            _service = service;
            _context = context;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            int TotalCount = _context.Messages.Where(x => !x.IsDeleted).Count();
            ViewBag.TotalPage = (int)Math.Ceiling((decimal)TotalCount / 8);
            ViewBag.CurrentPage = page;
            int count = 8;
            var result = await _service.GetAllAsync(count,page);
            return View(result.items);
        }
   
        [HttpGet]
        public async Task<IActionResult> Show(int id)
        {
            var result = await _service.GetAsync(id);
            if (result.StatusCode == 404)
            {
                return NotFound();
            }
            return View(result.items);
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