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
    [Authorize(Roles = "SuperAdmin")]
    public class AdminController : Controller
    {
        private readonly IAccountService _service;
        private readonly IWebHostEnvironment _evn;
        private readonly ICountryService _countryService;
        private readonly ILogger<AdminController> _logger;

        public AdminController(IAccountService service, IWebHostEnvironment evn, ICountryService countryService, ILogger<AdminController> logger)
        {
            _service = service;
            _evn = evn;
            _countryService = countryService;
            _logger = logger;
        }
        public async Task<IActionResult> Index(int page =1)
        {
            var result = await _service.GetAllAdmin(0, 0);
            int TotalCount = ((IEnumerable<AppUser>)result.items).Count();
            ViewBag.TotalPage = (int)Math.Ceiling((decimal)TotalCount / 5);
            ViewBag.CurrentPage = page;
            int count = 5;
            result = await _service.GetAllAdmin(count, page);
            List<AppUser> admins = (List<AppUser>)result.items;
            return View(admins);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var resultCountry = await _countryService.GetAllAsync(0, 0);
            ViewBag.Countries = resultCountry.items;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(AdminDto dto)
        {
            var resultCountry = await _countryService.GetAllAsync(0, 0);
            ViewBag.Countries = resultCountry.items;
            if (!ModelState.IsValid)
            {
                return View(dto);
            }
            AppUser Admin = new AppUser
            {
                Name = dto.Name,
                Surname = dto.Surname,
                Email = dto.Email,
                UserName = dto.UserName,
                CountryId = dto.CountryId,
                UserPricingId = 3,
                EmailConfirmed = true
            };
            Admin.Image = dto.file.CreateImage(_evn.WebRootPath, "Images/Users");
            await _service.Create(Admin, dto.Password, true);
            _logger.LogInformation("Admin Created by " + User.FindFirstValue(ClaimTypes.NameIdentifier));
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(string id)
        {
            var resultCountry = await _countryService.GetAllAsync(0, 0);
            var result = await _service.GetAllAdmin(0,0);
            ViewBag.Countries = resultCountry.items;
            List<AppUser> admins = (List<AppUser>)result.items;


            var user1 = admins.FirstOrDefault(x => x.Id == id);
            UpdateDto dto = new UpdateDto()
            {
                UserName = user1.UserName,
                Email = user1.Email,
                Name = user1.Name,
                Surname = user1.Surname,
                CountryId = user1.CountryId,
                Image = user1.Image
            };
            return View(dto);
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Update(string id, UpdateDto dto)
        {
            var resultCountry = await _countryService.GetAllAsync(0, 0);
            ViewBag.Countries = resultCountry.items;
            var result = await _service.GetUserById(id);
            AppUser appUser = (AppUser)result.items;
            if (!ModelState.IsValid)
            {
                return View(dto);
            }
             result = await _service.Update(dto,appUser);
            if (result.StatusCode != 203)
            {
                if (result.StatusCode == 404)
                {
                    return NotFound();
                }
                ModelState.AddModelError("", result.Description);
                return View(dto);
            }
            _logger.LogInformation("Admin Updated by " + User.FindFirstValue(ClaimTypes.NameIdentifier));
            return RedirectToAction(nameof(Index));

        }
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
            _logger.LogInformation("Admin Removed by " + User.FindFirstValue(ClaimTypes.NameIdentifier));
            return RedirectToAction(nameof(Index));
        }
    }
}
