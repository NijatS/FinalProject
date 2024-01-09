using Braintree;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Miles.Core.Entities;
using Miles.Service.Services.Interfaces;
using Miles.Service.ViewModels;
using NuGet.Protocol;
using System.Globalization;

namespace Miles.App.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class HomeController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly ICarService _carService;
        private readonly IBidService _bidService;
        private readonly IStatusService _statusService;
        private readonly IStaffService _staffService;

        public HomeController(IAccountService accountService, ICarService carService, IBidService bidService, IStatusService statusService, IStaffService staffService)
        {
            _accountService = accountService;
            _carService = carService;
            _bidService = bidService;
            _statusService = statusService;
            _staffService = staffService;
        }
        public async Task<IActionResult> Search(string? date, string? todate)
        {
            var result = await _accountService.GetAllAdmin(0, 0);
            AdminPanelVM adminPanelVM = new AdminPanelVM
            {
                Admins = (IEnumerable<AppUser>)result.items
            };

            CultureInfo culture = new CultureInfo("en-US");
            if (date != "null" && todate == "null")
            {
                DateTime tempDate = Convert.ToDateTime(date, culture);
                result = await _carService.GetAllAsync(0, 0, x => x.StatusId == 3 && x.WinDate > tempDate);
                adminPanelVM.Cars = (IEnumerable<Car>)result.items;
                result = await _bidService.GetAllAsync(0, 0, x => !x.IsDeleted && x.CreatedAt > tempDate);
                adminPanelVM.Bids = (IEnumerable<Bid>)result.items;
                return Json(adminPanelVM);
            }
            else if (todate != "null" && date == "null")
            {
                DateTime tempDate = Convert.ToDateTime(todate, culture);
                result = await _carService.GetAllAsync(0, 0, x => x.StatusId == 3 && x.WinDate < tempDate);
                adminPanelVM.Cars = (IEnumerable<Car>)result.items;
                result = await _bidService.GetAllAsync(0, 0, x => !x.IsDeleted && x.CreatedAt < tempDate);
                adminPanelVM.Bids = (IEnumerable<Bid>)result.items;
                return Json(adminPanelVM);
            }
            else if (todate == "null" && date == "null")
            {
                return Json(adminPanelVM);
            }
            else 
            {
                DateTime tempDate = Convert.ToDateTime(date, culture);
                DateTime tempDate1 = Convert.ToDateTime(todate, culture);
                result = await _carService.GetAllAsync(0, 0, x => x.StatusId == 3 && x.WinDate > tempDate && x.WinDate < tempDate1);
                adminPanelVM.Cars = (IEnumerable<Car>)result.items;
                result = await _bidService.GetAllAsync(0, 0, x => !x.IsDeleted && x.CreatedAt > tempDate && x.CreatedAt < tempDate1);
                adminPanelVM.Bids = (IEnumerable<Bid>)result.items;
                return Json(adminPanelVM);
            }
        }
        public async Task<IActionResult> Index(string? date,string? todate)
        {
            var result = await _accountService.GetAllAdmin(0, 0);
            AdminPanelVM adminPanelVM = new AdminPanelVM {
                Admins = (IEnumerable<AppUser>)result.items
            };
            result = await _carService.GetAllAsync(0, 0, x=>x.StatusId==3);
            adminPanelVM.Cars = (IEnumerable<Car>)result.items;
            result = await _bidService.GetAllAsync(0, 0,null);
            adminPanelVM.Bids =(IEnumerable<Bid>)result.items;
            result = await _accountService.GetAllUsers(0, 0);
            adminPanelVM.Users = (IEnumerable<AppUser>)result.items;
            result = await _statusService.GetAllAsync(0, 0);
            adminPanelVM.Statuses = (IEnumerable<Status>)result.items;
            result = await _staffService.GetAllAsync(0, 0);
            adminPanelVM.Staffs = (IEnumerable<Staff>)result.items;
         
            return View(adminPanelVM);
        }
        public async Task<IActionResult> Date(string? date)
        {
            CultureInfo culture = new CultureInfo("en-US");
            DateTime tempDate = Convert.ToDateTime(date, culture);
            if (date is null)
            {
                return Json(null);
            }
            return Json(tempDate);
        }
    }
}
