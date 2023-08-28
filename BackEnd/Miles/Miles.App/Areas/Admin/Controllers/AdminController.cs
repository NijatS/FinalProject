using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Miles.Core.Entities;
using Miles.Data.Context;
using Miles.Service.Services.Interfaces;

namespace Miles.App.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin")]
    public class AdminController : Controller
    {
        private readonly MilesAppDbContext _context;
        private readonly IAccountService _service;
        //private readonly RoleManager<IdentityRole> _roleManager;
        //private readonly UserManager<AppUser> _userManager;

        public AdminController(MilesAppDbContext context, IAccountService service)
        {
            _context = context;
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _service.GetAllAdmin();
            List<AppUser> admins = (List<AppUser>)result.items;
            return View(admins);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        //public async Task<IActionResult> Create(AdminVM adminVM)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(adminVM);
        //    }
        //    AppUser Admin = new AppUser
        //    {
        //        Name = adminVM.Name,
        //        Surname = adminVM.Surname,
        //        Email = adminVM.Email,
        //        UserName = adminVM.UserName,
        //        EmailConfirmed = true
        //    };
        //    await _userManager.CreateAsync(Admin, adminVM.Password);
        //    await _userManager.AddToRoleAsync(Admin, "Admin");
        //    return RedirectToAction(nameof(Index));
        //}
        //public async Task<IActionResult> Update(string id)
        //{
        //    var users = await _context.Users.ToListAsync();
        //    List<AppUser> admins = new List<AppUser>();
        //    foreach (var user in users)
        //    {
        //        if (await _userManager.IsInRoleAsync(user, "Admin"))
        //        {
        //            admins.Add(user);
        //        }
        //    }
        //    var user1 = admins.FirstOrDefault(x => x.Id == id);
        //    UpdatedUserVM updatedUserVM = new UpdatedUserVM()
        //    {
        //        UserName = user1.UserName,
        //        Email = user1.Email,
        //        Name = user1.Name,
        //        Surname = user1.Surname,
        //    };
        //    return View(updatedUserVM);
        //}
        //[HttpPost]
        //[Authorize]
        //public async Task<IActionResult> Update(string id, UpdatedUserVM model)
        //{
        //    var users = await _context.Users.ToListAsync();
        //    List<AppUser> admins = new List<AppUser>();
        //    foreach (var user in users)
        //    {
        //        if (await _userManager.IsInRoleAsync(user, "Admin"))
        //        {
        //            admins.Add(user);
        //        }
        //    }
        //    var user1 = admins.FirstOrDefault(x => x.Id == id);
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }
        //    if (user1 is null)
        //    {
        //        return NotFound();
        //    }
        //    user1.Name = model.Name;
        //    user1.Email = model.Email;
        //    user1.Surname = model.Surname;
        //    user1.UserName = model.UserName;
        //    var result = await _userManager.UpdateAsync(user1);
        //    if (!result.Succeeded)
        //    {
        //        foreach (var item in result.Errors)
        //        {
        //            ModelState.AddModelError("", item.Description);
        //        }
        //        return View(model);
        //    }

        //    if (!string.IsNullOrWhiteSpace(model.Password))
        //    {
        //        result = await _userManager.ChangePasswordAsync(user1, model.CurrentPassword, model.Password);
        //        if (!result.Succeeded)
        //        {
        //            foreach (var item in result.Errors)
        //            {
        //                ModelState.AddModelError("", item.Description);
        //            }
        //            return View(model);
        //        }

        //    }

        //    return RedirectToAction(nameof(Index));
        //}
        //public async Task<IActionResult> Remove(string id)
        //{
        //    var users = await _context.Users.ToListAsync();
        //    List<AppUser> admins = new List<AppUser>();
        //    foreach (var user in users)
        //    {
        //        if (await _userManager.IsInRoleAsync(user, "Admin"))
        //        {
        //            admins.Add(user);
        //        }
        //    }
        //    var user1 = admins.FirstOrDefault(x => x.Id == id);
        //    if (user1 is null)
        //    {
        //        return NotFound();
        //    }
        //    _context.Users.Remove(user1);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}
    }
}
