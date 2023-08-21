using Humanizer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Miles.Core.Entities;
using Miles.Data.Context;
using Miles.Service.Dtos.Accounts;
using Miles.Service.Services.Implementations;
using Miles.Service.Services.Interfaces;
using NuGet.Common;

namespace Miles.App.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _service;
        private readonly IEmailService _mailService;
        private readonly ICountryService _countryService;
        public AccountController(IEmailService mailService, IAccountService service, ICountryService countryService)
        {
            _mailService = mailService;
            _service = service;
            _countryService = countryService;
        }
        [HttpGet]
        public async Task<IActionResult> SignUp()
        {
            var result = await _countryService.GetAllAsync(0, 0);
            ViewBag.Countries = result.items;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(RegisterDto dto)
        {
            var resultCountry = await _countryService.GetAllAsync(0, 0);
            ViewBag.Countries = resultCountry.items;
            if (!ModelState.IsValid)
            {
                return View(dto);
            }
            var result = await _service.SignUp(dto);
            if(result.StatusCode != 200)
            {
                ModelState.AddModelError("", result.Description);
                return View(dto);
            }
            AppUser appUser = (AppUser) result.items ;
            
           
            string? link = Url.Action(action: "VerifyEmail", controller: "Account", values: new
            {
                token = result.Token,
                mail = appUser.Email
            }, protocol: Request.Scheme);

            await _mailService.SendMail("nicatsoltanli03@gmail.com", appUser.Email,
                "Verify Email", "Click me to verify email", link, appUser.Name + " " + appUser.Surname);

            TempData["Register"] = "Please verify your email";
            return RedirectToAction("index", "home");
        }
        public async Task<IActionResult> VerifyEmail(string token, string mail)
        {
            var result  = _service.VerifyEmail(token, mail);
            if (result.Result.StatusCode == 404)
            {
                return NotFound();
            }
            TempData["Verify"] = "Succesfully SignUp";
            return RedirectToAction("index", "home");
        }
        [Authorize]
        public async Task<IActionResult> Info()
        {
            var result =await _service.Info();
            if(result.StatusCode != 200)
            {
                TempData["AdminInfo"] = result.Description;
                return RedirectToAction("index", "home");
            }
            AppUser appUser = (AppUser)result.items;
            return View(appUser);

        }
        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }
            var result = await _service.Login(dto);
            if(result.StatusCode != 200)
            {
                ModelState.AddModelError("", result.Description);
                return View(dto);
            }
            return RedirectToAction("index", "home");
        }
        [Authorize]
        public async Task<IActionResult> LogOut()
        {
            var result = await _service.LogOut();
            return RedirectToAction("index", "home");
        }
        [HttpGet]
        public async Task<IActionResult> ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgetPassword(string mail)
        {
           var result = await _service.ForgetPassword(mail);
            if(result.StatusCode != 200)
            {
                if(result.StatusCode == 404)
                {
                    return NotFound();
                }
                ModelState.AddModelError("", result.Description);
                return View(mail);
            }
            AppUser appUser = (AppUser)result.items;
            string? link = Url.Action(action: "ResetPassword", controller: "Account", values: new
            {
                token = result.Token,
                mail = mail
            }, protocol: Request.Scheme);

            await _mailService.SendMail("nicatsoltanli03@gmail.com", appUser.Email,
            "Reset Password", "Click me for reseting password", link, appUser.Name + " " + appUser.Surname);
            return RedirectToAction("index", "home");
        }
        [HttpGet]
        public async Task<IActionResult> ResetPassword(string mail, string token)
        {
            var result = await _service.ResetPasswordGet(mail, token);
            if (result.StatusCode != 200)
            {
                if (result.StatusCode == 404)
                {
                    return NotFound();
                }
                ModelState.AddModelError("", result.Description);
                return View(mail);
            }
            ResetPasswordDto dto = (ResetPasswordDto)result.items;
            return View(dto);
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }
            var result = await _service.ResetPasswordPost(dto);
            if (result.StatusCode != 203)
            {
                if (result.StatusCode == 404)
                {
                    return NotFound();
                }
                ModelState.AddModelError("", result.Description);
                return View(dto);
            }
            return RedirectToAction("login", "account");
        }
        [Authorize]
        public async Task<IActionResult> Update()
        {
            var result = await _service.GetUser();
            if(result.StatusCode != 200)
            {
                return NotFound();
            }
            AppUser user = (AppUser)result.items;
            UpdateDto dto = new UpdateDto()
            {
                UserName = user.UserName,
                Email = user.Email,
                Name = user.Name,
                Surname = user.Surname,
            };
            return View(dto);
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Update(UpdateDto dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }
            var result = await _service.Update(dto);
            if(result.StatusCode != 203)
            {
                if(result.StatusCode == 404)
                {
                    return NotFound();
                }
                ModelState.AddModelError("", result.Description);
                return View(dto);
            }
            return RedirectToAction(nameof(Info));
        }
        //public async Task<IActionResult> AddRole()
        //{
        //    IdentityRole role = new IdentityRole
        //    {
        //        Name = "User"
        //    };
        //    IdentityRole role1 = new IdentityRole
        //    {
        //        Name = "Admin"
        //    };
        //    IdentityRole role2 = new IdentityRole
        //    {
        //        Name = "SuperAdmin"
        //    };
        //   await _roleManager.CreateAsync(role);
        //   await _roleManager.CreateAsync(role1);
        //    await _roleManager.CreateAsync(role2);
        //    return RedirectToAction("index", "home");
        //}
    }
}
