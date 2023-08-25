using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Miles.Core.Entities;
using Miles.Service.Dtos.Subscribes;
using Miles.Service.Services.Interfaces;
using Miles.Service.ViewModels;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Miles.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IBlogService _blogService;
        private readonly ITextWhyService _textWhyService;
        private readonly ISettingService _settingService;
        private readonly IAssociateService _associateService;
        private readonly ISubscribeService _subscribeService;
        private readonly ICarService _carService;
        public HomeController(ISliderService sliderService, IBlogService blogService, ITextWhyService textWhyService, ISettingService settingService, IAssociateService associateService, ISubscribeService subscribeService, ICarService carService)
        {
            _sliderService = sliderService;
            _blogService = blogService;
            _textWhyService = textWhyService;
            _settingService = settingService;
            _associateService = associateService;
            _subscribeService = subscribeService;
            _carService = carService;
        }
        public async Task<IActionResult> Index()
        {
            var resultSlide = await _sliderService.GetAllAsync(0, 0);
            var resultBlog = await _blogService.GetAllAsync(0, 0, null);
            var resultText = await _textWhyService.GetAllAsync(0, 0);
            var resultAssociate = await _associateService.GetAllAsync(0, 0);
            var resultCar = await _carService.GetAllAsync(0, 0,null);
            HomeVM homeVM = new HomeVM
            {
                Sliders = (IEnumerable<Slider>)resultSlide.items,
                Blogs = (IEnumerable<Blog>)resultBlog.items,
                Why = (IEnumerable<TextWhy>)resultText.items,
                Associates = (IEnumerable<Associate>)resultAssociate.items,
                Setting = _settingService.GetSetting().Result.Setting,
                Cars = (IEnumerable<Car>)resultCar.items,
            };
            return View(homeVM);
        }
        [HttpPost]
        public async Task<IActionResult> PostSubscribe(SubscribePostDto dto)
        {
            if (!ModelState.IsValid)
            {
                TempData["Mail"] = "Please add valid email";
                return RedirectToAction(nameof(Index));
            }
            var result= await _subscribeService.CreateAsync(dto);
            if(result.StatusCode != 201)
            {
                TempData["Mail"] = "This email is registered";
                return RedirectToAction(nameof(Index));
            }
            TempData["Verify"] = "Added succesfully";
            return RedirectToAction(nameof(Index));
        }
    }
}