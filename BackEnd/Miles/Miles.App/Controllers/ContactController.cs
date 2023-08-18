using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Miles.Service.ViewModels;
using Miles.Core.Entities;
using Miles.Service.Dtos.Messages;
using Miles.Service.Services.Interfaces;
using System.Text.RegularExpressions;

namespace Miles.App.Controllers
{
    public class ContactController : Controller
    {
        private readonly IMessageService _service;
        private readonly ISettingService _settingService;
        public ContactController(IMessageService service, ISettingService settingService)
        {
            _service = service;
            _settingService = settingService;
        }

        public async Task<IActionResult> Index()
        {
            var result =await _settingService.GetSetting();
            ContactVM contactVM = new ContactVM()
            {
                Setting = result.Setting,
            };
            return View(contactVM);
        }
        [HttpPost]
        public async Task<IActionResult> SendEmail(MessagePostDto dto)
        {
            if (!ModelState.IsValid)
            {
                TempData["Email"] = "Please fill All fields";
                return RedirectToAction(nameof(Index));
            }
            string strRegex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

            Regex re = new Regex(strRegex);
            if (!re.IsMatch(dto.Email))
            {
                TempData["Email"] = "Please add valid email";
                return RedirectToAction(nameof(Index));
            }
            if (!ModelState.IsValid)
            {
               TempData["Message"] = "Please fill all inputs qaqa";
                return RedirectToAction(nameof(Index));
            }
           
            var result = await _service.CreateAsync(dto);
            TempData["Success"] = "Successfully send message";
            return RedirectToAction(nameof(Index));
        }
    }
}