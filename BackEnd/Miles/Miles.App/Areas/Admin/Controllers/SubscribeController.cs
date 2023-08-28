using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Miles.Data.Context;
using Miles.Service.Dtos.Subscribes;
using Miles.Service.Services.Interfaces;

namespace Miles.App.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class SubscribeController : Controller
    {
        private readonly ISubscribeService _service;
        private readonly MilesAppDbContext _context;

        public SubscribeController(ISubscribeService service, MilesAppDbContext context)
        {
            _service = service;
            _context = context;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            int TotalCount = _context.Subscribes.Where(x => !x.IsDeleted).Count();
            ViewBag.TotalPage = (int)Math.Ceiling((decimal)TotalCount / 8);
            ViewBag.CurrentPage = page;
            int count = 8;
            var result = await _service.GetAllAsync(count,page);
            return View(result.items);
        }
   
        [HttpGet]
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
