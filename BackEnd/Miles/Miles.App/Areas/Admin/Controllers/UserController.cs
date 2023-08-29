﻿using Humanizer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Miles.Core.Entities;
using Miles.Data.Context;
using Miles.Service.Dtos.Accounts;
using Miles.Service.Extensions;
using Miles.Service.Services.Interfaces;

namespace Miles.App.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class UserController : Controller
    {
        private readonly IAccountService _service;
        private readonly IWebHostEnvironment _evn;
        private readonly ICountryService _countryService;
 

        public UserController(IAccountService service, IWebHostEnvironment evn, ICountryService countryService)
        {
            _service = service;
            _evn = evn;
            _countryService = countryService;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _service.GetAllUsers();
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
            return RedirectToAction(nameof(Index));
        }
    }
}