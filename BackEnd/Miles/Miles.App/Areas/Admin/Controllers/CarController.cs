using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Miles.Core.Entities;
using Miles.Data.Context;
using Miles.Service.Dtos.Cars;
using Miles.Service.Services.Implementations;
using Miles.Service.Services.Interfaces;
using NuGet.Protocol;
using System.Security.Claims;
using System.Text.Json;

namespace Miles.App.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class CarController : Controller
    {
        private readonly ICarService _service;
        private readonly IFuelService _fuelService;
        private readonly IBanService _banService;
        private readonly IColorService _colorService;
        private readonly ICountryService _countryService;
        private readonly IBrandService _brandService;
        private readonly IAccountService _accountService;
        private readonly ICarImageService _carImageService;
        private readonly ILogger<CarController> _logger;
        public CarController(ICarService service,IFuelService fuelService, IBanService banService, IColorService colorService, ICountryService countryService, IBrandService brandService, IAccountService accountService, ICarImageService carImageService, ILogger<CarController> logger)
        {
            _service = service;
            _fuelService = fuelService;
            _banService = banService;
            _colorService = colorService;
            _countryService = countryService;
            _brandService = brandService;
            _accountService = accountService;
            _carImageService = carImageService;
            _logger = logger;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            var result = await _service.GetAllAsync(0, 0,x=>!x.IsDeleted);
            int TotalCount = ((IEnumerable<Car>)result.items).Count();
            ViewBag.TotalPage = (int)Math.Ceiling((decimal)TotalCount / 5);
            ViewBag.CurrentPage = page;
            int count = 5;
             result = await _service.GetAllAsync(count,page, null);
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
			var resultAccount = await _accountService.GetAllUsers(0, 0);
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
			var resultAccount = await _accountService.GetAllUsers(0,0);
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
            _logger.LogInformation("Car Created by " + User.FindFirstValue(ClaimTypes.NameIdentifier));
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
            var resultAccount = await _accountService.GetAllUsers(0,0);
            var resultImage = await _carImageService.GetAllAsync(0, 0,x=>x.CarId==id&& !x.IsDeleted);
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
			var resultAccount = await _accountService.GetAllUsers(0, 0);
			var resultImage = await _carImageService.GetAllAsync(0, 0, x => x.CarId == id && !x.IsDeleted);
			ViewBag.Users = resultAccount.items;
			ViewBag.Fuels = resultFuel.items;
			ViewBag.Bans = resultBan.items;
			ViewBag.Colors = resultColor.items;
			ViewBag.Countries = resultCountry.items;
			ViewBag.Brands = resultBrand.items;
			ViewBag.Images = resultImage.items;
			if (!ModelState.IsValid)
            {
                return View(dto);
            }
			if (dto.FormFiles is not null)
            {
                int length = ((IEnumerable<CarImage>)resultImage.items).Count() + dto.FormFiles.Count();
				if (length > 10 || length < 3)
				{
					ModelState.AddModelError("FormFiles", "Min 3,Max 10 Image");
					return View(dto);
				}
			}
           
			var result = await _service.UpdateAsync(id,dto);
            if (result.StatusCode == 400)
            {
                ModelState.AddModelError("", result.Description);
                return View(dto);
            }
            _logger.LogInformation("Car Updated by " + User.FindFirstValue(ClaimTypes.NameIdentifier));
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Remove(int id)
        {
            var result = await _service.RemoveAsync(id);
            if(result.StatusCode == 404)
            {
                return NotFound();
            }
            _logger.LogInformation("Car Removed by " + User.FindFirstValue(ClaimTypes.NameIdentifier));
            return RedirectToAction(nameof(Index));
        }
		public async Task<IActionResult> SetAsMainImage(int id)
		{
            var result =await _carImageService.GetAsync(id,null);
			CarImage carImage = (CarImage)result.itemView;

			if (carImage == null)
			{
				return Json(new { status = 404 });
			}

			carImage.isMain = true;
			result = await _carImageService.GetAsync(id, x => x.isMain && x.CarId == carImage.CarId);
			CarImage? carImage1 = (CarImage)result.itemView;
			if (carImage1 is not null)
            {
                carImage1.isMain = false;
            }
			await _carImageService.Save();
            _logger.LogInformation("Car Main Image Updated by " + User.FindFirstValue(ClaimTypes.NameIdentifier));
            return Json(new { status = 200 });
		}
		public async Task<IActionResult> RemoveImage(int id)
		{
            var result = await _carImageService.GetAllAsync(0, 0, x => !x.IsDeleted && x.Id == id);
            CarImage? carImage = ((IEnumerable<CarImage>)result.items).FirstOrDefault();

			if (carImage == null)
				return Json(new { status = 404, desc = "image not found" });

			if (carImage.isMain)
				return Json(new { status = 400, desc = "You cannot remove main image" });

			carImage.IsDeleted = true;
			await _carImageService.Save();
            _logger.LogInformation("Car Image Removed by " + User.FindFirstValue(ClaimTypes.NameIdentifier));
            return Json(new { status = 200 });
		}
	}
}
