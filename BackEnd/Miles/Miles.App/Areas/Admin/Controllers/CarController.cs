using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Miles.Core.Entities;
using Miles.Data.Context;
using Miles.Service.Dtos.Cars;
using Miles.Service.Services.Implementations;
using Miles.Service.Services.Interfaces;
using NuGet.Protocol;
using System.Text.Json;

namespace Miles.App.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CarController : Controller
    {
        private readonly MilesAppDbContext _context;
        private readonly ICarService _service;
        private readonly IFuelService _fuelService;
        private readonly IBanService _banService;
        private readonly IColorService _colorService;
        private readonly ICountryService _countryService;
        private readonly IBrandService _brandService;
        private readonly IAccountService _accountService;
        private readonly ICarImageService _carImageService;
		public CarController(ICarService service, MilesAppDbContext context, IFuelService fuelService, IBanService banService, IColorService colorService, ICountryService countryService, IBrandService brandService, IAccountService accountService, ICarImageService carImageService)
		{
			_service = service;
			_context = context;
			_fuelService = fuelService;
			_banService = banService;
			_colorService = colorService;
			_countryService = countryService;
			_brandService = brandService;
			_accountService = accountService;
			_carImageService = carImageService;
		}

		public async Task<IActionResult> Index(int page = 1)
        {
            int TotalCount = _context.Cars.Where(x => !x.IsDeleted).Count();
            ViewBag.TotalPage = (int)Math.Ceiling((decimal)TotalCount / 4);
            ViewBag.CurrentPage = page;
            int count = 4;
            var result = await _service.GetAllAsync(count,page, null);
            return View(result.items);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var resultFuel = await _fuelService.GetAllAsync(0, 0);
            var resultBan = await _banService.GetAllAsync(0, 0);
            var resultColor = await _colorService.GetAllAsync(0, 0);
            var resultCountry = await _countryService.GetAllAsync(0, 0);
			var resultBrand = await _brandService.GetAllAsync(0, 0);
			var resultAccount = await _accountService.GetAllUsers();
			ViewBag.Users = resultAccount.items;
			ViewBag.Fuels = resultFuel.items;
            ViewBag.Bans = resultBan.items;
            ViewBag.Colors = resultColor.items;
            ViewBag.Countries = resultCountry.items;
			ViewBag.Brands = resultBrand.items;
			return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CarPostDto dto)
        {
			var resultFuel = await _fuelService.GetAllAsync(0, 0);
			var resultBan = await _banService.GetAllAsync(0, 0);
			var resultColor = await _colorService.GetAllAsync(0, 0);
			var resultCountry = await _countryService.GetAllAsync(0, 0);
			var resultBrand = await _brandService.GetAllAsync(0, 0);
			var resultAccount = await _accountService.GetAllUsers();
			ViewBag.Users = resultAccount.items;
			ViewBag.Fuels = resultFuel.items;
			ViewBag.Bans = resultBan.items;
			ViewBag.Colors = resultColor.items;
			ViewBag.Countries = resultCountry.items;
			ViewBag.Brands = resultBrand.items;
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
            var resultFuel = await _fuelService.GetAllAsync(0, 0);
            var resultBan = await _banService.GetAllAsync(0, 0);
            var resultColor = await _colorService.GetAllAsync(0, 0);
            var resultCountry = await _countryService.GetAllAsync(0, 0);
            var resultBrand = await _brandService.GetAllAsync(0, 0);
            var resultAccount = await _accountService.GetAllUsers();
            var resultImage = await _carImageService.GetAllAsync(0, 0,x=>x.CarId==id);
            ViewBag.Users = resultAccount.items;
            ViewBag.Fuels = resultFuel.items;
            ViewBag.Bans = resultBan.items;
            ViewBag.Colors = resultColor.items;
            ViewBag.Countries = resultCountry.items;
            ViewBag.Brands = resultBrand.items;
            ViewBag.Images = resultImage.items;
            var result = await _service.GetAsync(id);
            if (result.StatusCode == 404)
            {
                return NotFound();
            }
            return View(result.items);
        }
        [HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Update(int id,CarUpdateDto dto)
        {
            var resultFuel = await _fuelService.GetAllAsync(0, 0);
            var resultBan = await _banService.GetAllAsync(0, 0);
            var resultColor = await _colorService.GetAllAsync(0, 0);
            var resultCountry = await _countryService.GetAllAsync(0, 0);
            var resultBrand = await _brandService.GetAllAsync(0, 0);
            var resultAccount = await _accountService.GetAllUsers();
            ViewBag.Users = resultAccount.items;
            ViewBag.Fuels = resultFuel.items;
            ViewBag.Bans = resultBan.items;
            ViewBag.Colors = resultColor.items;
            ViewBag.Countries = resultCountry.items;
            ViewBag.Brands = resultBrand.items;
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
