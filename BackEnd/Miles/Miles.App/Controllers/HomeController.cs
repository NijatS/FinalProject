﻿using Microsoft.AspNetCore.Mvc;
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
        public HomeController(ISliderService sliderService, IBlogService blogService, ITextWhyService textWhyService, ISettingService settingService, IAssociateService associateService, ISubscribeService subscribeService)
        {
            _sliderService = sliderService;
            _blogService = blogService;
            _textWhyService = textWhyService;
            _settingService = settingService;
            _associateService = associateService;
            _subscribeService = subscribeService;
        }

        public async Task<IActionResult> Index()
        {
            var resultSlide = await _sliderService.GetAllAsync(0, 0);
            var resultBlog = await _blogService.GetAllAsync(0, 0, null);
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
        [HttpPost]
        public async Task<IActionResult> PostSubscribe(SubscribePostDto dto)
        {
            //string strRegex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

            //Regex re = new Regex(strRegex);
            if (!ModelState.IsValid)
            {
                TempData["Mail"] = "Please add valid email";
                return RedirectToAction(nameof(Index));
            }
            //if (!re.IsMatch(subscribe.Email))
            //{
            //    return RedirectToAction("index", "home");
            //}
            TempData["Verify"] = "Added succesfully";
            await _subscribeService.CreateAsync(dto);
            return RedirectToAction(nameof(Index));
        }
    }
}