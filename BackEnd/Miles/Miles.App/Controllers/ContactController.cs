using Microsoft.AspNetCore.Mvc;
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
        private readonly IEmailService _emailService;
        private readonly IAccountService _accountService;

        public ContactController(IMessageService service, ISettingService settingService, IEmailService emailService, IAccountService accountService)
        {
            _service = service;
            _settingService = settingService;
            _emailService = emailService;
            _accountService = accountService;
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
            var result = await _accountService.GetUserById(dto.appUserId);
            AppUser appUser = (AppUser) result.items;
            if(dto.Address is null)
            {
                dto.Address = "For dealer";
            }
            if (!ModelState.IsValid)
            {
                TempData["Email"] = "Please fill All fields";
                return Redirect(Request.Headers["Referer"].ToString());
            }
            string strRegex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

            Regex re = new Regex(strRegex);
            if (!re.IsMatch(dto.Email))
            {
                TempData["Email"] = "Please add valid email";
                return Redirect(Request.Headers["Referer"].ToString());
            }
            if (!ModelState.IsValid)
            {
               TempData["Message"] = "Please fill all inputs qaqa";
                return Redirect(Request.Headers["Referer"].ToString());
            }
            result = await _service.CreateAsync(dto);
            TempData["Success"] = "Successfully send message";
            if (dto.Address == "For dealer")
            {
                string text = "User: " + dto.FirstName + "\n" +
                              "Email:" + dto.Email + "\n" +
                              "Number: " + dto.Phone + "\n" +
                              "Text: " + dto.Text + "\n";
                await _emailService.SendMail("nicatsoltanli03@gmail.com", appUser.Email,
                "Auction Info",text, null, appUser.Name + " " + appUser.Surname);
            }
            return Redirect(Request.Headers["Referer"].ToString());

        }
    }
}