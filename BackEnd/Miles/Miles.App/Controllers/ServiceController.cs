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

        public ServiceController(ISettingService settingService, ITextWhyService textWhyService, IUserPricingService userPricingService)
        {
            _settingService = settingService;
            _textWhyService = textWhyService;
            _userPricingService = userPricingService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _settingService.GetSetting();
            var resultText = await _textWhyService.GetAllAsync(0, 0);
            var userPricing = await _userPricingService.GetAllAsync(0, 0);

            ServiceVM serviceVM = new ServiceVM
			{
                Why = (IEnumerable<TextWhy>)resultText.items,
                UserPricings = (IEnumerable<UserPricing>)userPricing.items,
                Setting = result.Setting,
			};

            return View(serviceVM);
			
		}
	}
}
