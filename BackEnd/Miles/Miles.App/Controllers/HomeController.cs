using Microsoft.AspNetCore.Mvc;
using Miles.Core.Entities;
using Miles.Service.Services.Interfaces;
using Miles.Service.ViewModels;
using System.Collections.Generic;

namespace Miles.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IBlogService _blogService;
        private readonly ITextWhyService _textWhyService;
        private readonly ISettingService _settingService;
        private readonly IAssociateService _associateService;
        public HomeController(ISliderService sliderService, IBlogService blogService, ITextWhyService textWhyService, ISettingService settingService, IAssociateService associateService)
        {
            _sliderService = sliderService;
            _blogService = blogService;
            _textWhyService = textWhyService;
            _settingService = settingService;
            _associateService = associateService;
        }

        public async Task<IActionResult> Index()
        {
            var resultSlide = await _sliderService.GetAllAsync(0, 0);
            var resultBlog = await _blogService.GetAllAsync(0, 0);
            var resultText = await _textWhyService.GetAllAsync(0, 0);
            var resultAssociate = await _associateService.GetAllAsync(0, 0);
            HomeVM homeVM = new HomeVM
            {
                Sliders =(IEnumerable<Slider>)resultSlide.items,
                Blogs = (IEnumerable<Blog>)resultBlog.items,
                Why = (IEnumerable<TextWhy>)resultText.items,
                Associates = (IEnumerable<Associate>)resultAssociate.items,
                Setting = _settingService.GetSetting().Result.Setting
            };
            return View(homeVM);
        }
    }
}