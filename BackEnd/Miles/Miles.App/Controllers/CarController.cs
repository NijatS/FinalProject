using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private readonly ICarImageService _carImageService;


        public CarController(ICarService service, IFuelService fuelService, IBanService banService, IColorService colorService, ICountryService countryService, IBrandService brandService, IAccountService accountService, ICarImageService carImageService)
        {
            _service = service;
            _fuelService = fuelService;
            _banService = banService;
            _colorService = colorService;
            _countryService = countryService;
            _brandService = brandService;
            _accountService = accountService;
            _carImageService = carImageService;
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
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var resultFuel = await _fuelService.GetAllAsync(0, 0);
            var resultBan = await _banService.GetAllAsync(0, 0);
            var resultColor = await _colorService.GetAllAsync(0, 0);
            var resultCountry = await _countryService.GetAllAsync(0, 0);
            var resultBrand = await _brandService.GetAllAsync(0, 0);
            var resultImage = await _carImageService.GetAllAsync(0, 0, x => x.CarId == id && !x.IsDeleted);
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
        public async Task<IActionResult> Update(int id, CarUpdateDto dto)
        {
            var resultFuel = await _fuelService.GetAllAsync(0, 0);
            var resultBan = await _banService.GetAllAsync(0, 0);
            var resultColor = await _colorService.GetAllAsync(0, 0);
            var resultCountry = await _countryService.GetAllAsync(0, 0);
            var resultBrand = await _brandService.GetAllAsync(0, 0);
            var resultImage = await _carImageService.GetAllAsync(0, 0, x => x.CarId == id && !x.IsDeleted);
            var resultAccount = await _accountService.GetUser();
            ViewBag.Fuels = resultFuel.items;
            ViewBag.Bans = resultBan.items;
            ViewBag.Colors = resultColor.items;
            ViewBag.Countries = resultCountry.items;
            ViewBag.Brands = resultBrand.items;
            ViewBag.Images = resultImage.items;
            AppUser appUser = (AppUser)resultAccount.items;
            dto.AppUserId = appUser.Id;
            if (!ModelState.IsValid)
            {
                return View(dto);
            }
            if (dto.FormFiles is not null)
            {
                int length = ((IEnumerable<CarImage>)resultImage.items).Count() + dto.FormFiles.Count();
                if (length > 5 || length < 3)
                {
                    ModelState.AddModelError("FormFiles", "Min 3,Max 5 Image");
                    return View(dto);
                }
            }

            var result = await _service.UpdateAsync(id, dto);
            if (result.StatusCode == 400)
            {
                ModelState.AddModelError("", result.Description);
                return View(dto);
            }
            return RedirectToAction("info","account");
        }
        public async Task<IActionResult> SetAsMainImage(int id)
        {
            var result = await _carImageService.GetAsync(id,null);
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
            return Json(new { status = 200 });
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
        public async Task<IActionResult> GetCar(int carId)
        {
            var result = await _service.GetAsync(carId);
            if (result.StatusCode == 404)
            {
                return NotFound();
            }
            Car car =(Car)result.itemView;
            return Json(car);
        }
        public async Task<IActionResult> SellCar(int carId,string userId,bool status)
        {
            var result = await _service.GetAsync(carId);
            if (result.StatusCode == 404)
            {
                return NotFound();
            }
            CarUpdateDto dto = (CarUpdateDto)result.items;
            if(dto.AppUserId != userId)
            {
                return NotFound();

            }
            if (status)
            {
                dto.StatusId = 3;

            }
            else
            {
                dto.StatusId = 5;
            }
            await _service.UpdateAsync(carId, dto);
            return RedirectToAction("info", "account");
        }
    }
}
