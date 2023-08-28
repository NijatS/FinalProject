using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Miles.Core.Entities;
using Miles.Service.Dtos.Cars;
using Miles.Service.Services.Implementations;
using Miles.Service.Services.Interfaces;

namespace Miles.App.Controllers
{
    public class CarController : Controller
    {
		private readonly ICarService _service;
		private readonly IFuelService _fuelService;
		private readonly IBanService _banService;
		private readonly IColorService _colorService;
		private readonly ICountryService _countryService;
		private readonly IBrandService _brandService;
		private readonly IAccountService _accountService;


		public CarController(ICarService service, IFuelService fuelService, IBanService banService, IColorService colorService, ICountryService countryService, IBrandService brandService, IAccountService accountService)
		{
			_service = service;
			_fuelService = fuelService;
			_banService = banService;
			_colorService = colorService;
			_countryService = countryService;
			_brandService = brandService;
			_accountService = accountService;
		}
		[Authorize]
		[HttpGet]
		public async Task<IActionResult> Sell()
        {
			var resultFuel = await _fuelService.GetAllAsync(0, 0);
			var resultBan = await _banService.GetAllAsync(0, 0);
			var resultColor = await _colorService.GetAllAsync(0, 0);
			var resultCountry = await _countryService.GetAllAsync(0, 0);
			var resultBrand = await _brandService.GetAllAsync(0, 0);
			ViewBag.Fuels = resultFuel.items;
			ViewBag.Bans = resultBan.items;
			ViewBag.Colors = resultColor.items;
			ViewBag.Countries = resultCountry.items;
			ViewBag.Brands = resultBrand.items;
			return View();
        }
		[HttpPost]
		[Authorize]
		public async Task<IActionResult> Sell(CarPostDto dto)
		{
			var resultFuel = await _fuelService.GetAllAsync(0, 0);
			var resultBan = await _banService.GetAllAsync(0, 0);
			var resultColor = await _colorService.GetAllAsync(0, 0);
			var resultCountry = await _countryService.GetAllAsync(0, 0);
			var resultBrand = await _brandService.GetAllAsync(0, 0);
			var resultAccount = await _accountService.GetUser();
			ViewBag.Fuels = resultFuel.items;
			ViewBag.Bans = resultBan.items;
			ViewBag.Colors = resultColor.items;
			ViewBag.Countries = resultCountry.items;
			ViewBag.Brands = resultBrand.items;
			AppUser appUser= (AppUser)resultAccount.items;
			dto.AppUserId = appUser.Id;
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
			return RedirectToAction("info","account");
		}
        public async Task<IActionResult> Remove(int id)
        {
            var result = await _service.RemoveAsync(id);
            if (result.StatusCode == 404)
            {
                return NotFound();
            }
            return RedirectToAction("info", "account");
        }
    }
}
