using Humanizer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Miles.Core.Entities;
using Miles.Data.Context;
using Miles.Service.Dtos.Accounts;
using Miles.Service.Extensions;
using Miles.Service.Services.Interfaces;
using System.Security.Claims;

namespace Miles.App.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class UserController : Controller
    {
        private readonly IAccountService _service;
        private readonly IWebHostEnvironment _evn;
        private readonly ICountryService _countryService;
        private readonly ILogger<UserController> _logger;
        public UserController(IAccountService service, IWebHostEnvironment evn, ICountryService countryService, ILogger<UserController> logger)
        {
            _service = service;
            _evn = evn;
            _countryService = countryService;
            _logger = logger;
        }
        public async Task<IActionResult> Index(int page =1)
        {
            var result = await _service.GetAllUsers(0,0);
            int TotalCount = ((IEnumerable<AppUser>)result.items).Count();
            ViewBag.TotalPage = (int)Math.Ceiling((decimal)TotalCount / 5);
            ViewBag.CurrentPage = page;
            int count = 5;
            result = await _service.GetAllUsers(count,page);
            List<AppUser> users = (List<AppUser>)result.items;
            return View(users);
        }
        [HttpGet]
        public async Task<IActionResult> Remove(string id)
        {
            var result = await _service.Remove(id);
            if (result.StatusCode != 203)
            {
                if (result.StatusCode == 404)
                {
                    return NotFound();
                }
                ModelState.AddModelError("", result.Description);
                return RedirectToAction(nameof(Index));

            }
            _logger.LogInformation("User Removed by " + User.FindFirstValue(ClaimTypes.NameIdentifier));
            return RedirectToAction(nameof(Index));
        }
    }
}
