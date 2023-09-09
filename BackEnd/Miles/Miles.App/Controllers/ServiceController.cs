using Microsoft.AspNetCore.Mvc;
using Miles.Core.Entities;
using Miles.Service.Services.Interfaces;
using Miles.Service.ViewModels;

namespace Miles.App.Controllers
{
	public class ServiceController : Controller
	{
		private readonly ISettingService _settingService;
        private readonly ITextWhyService _textWhyService;
        private readonly IUserPricingService _userPricingService;
        private readonly ICarService _carService;
        private readonly IAccountService _accountService;
        private readonly IBidService _bidService;
        public ServiceController(ISettingService settingService, ITextWhyService textWhyService, IUserPricingService userPricingService, ICarService carService, IAccountService accountService, IBidService bidService)
        {
            _settingService = settingService;
            _textWhyService = textWhyService;
            _userPricingService = userPricingService;
            _carService = carService;
            _accountService = accountService;
            _bidService = bidService;
        }

        public async Task<IActionResult> Index()
        {
			ViewBag.IsDataLoading = true;
			var result = await _settingService.GetSetting();
            var resultText = await _textWhyService.GetAllAsync(0, 0);
            var userPricing = await _userPricingService.GetAllAsync(0, 0);
            var resultCar = await _carService.GetAllAsync(0, 0, null);
            var resultUser = await _accountService.GetAllUsers(0,0);
            var resultBid = await _bidService.GetAllAsync(0, 0,null);
            ServiceVM serviceVM = new ServiceVM
			{
                Why = (IEnumerable<TextWhy>)resultText.items,
                UserPricings = (IEnumerable<UserPricing>)userPricing.items,
                Setting = result.Setting,
                Cars = (IEnumerable<Car>)resultCar.items,
                AppUsers = (IEnumerable<AppUser>)resultUser.items,
                Bids =(IEnumerable<Bid>)resultBid.items,
        };
			ViewBag.IsDataLoading = false;
			return View(serviceVM);
			
		}
	}
}
