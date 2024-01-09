using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Miles.Core.Entities;
using Miles.Service.Dtos.Accounts;
using Miles.Service.Extensions;
using Miles.Service.Responses;
using Miles.Service.Services.Interfaces;
using Miles.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Services.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IWebHostEnvironment _evn;
        private readonly IHttpContextAccessor _http;
        public AccountService(UserManager<AppUser> userManager, IWebHostEnvironment evn, IHttpContextAccessor http, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _evn = evn;
            _http = http;
            _signInManager = signInManager;
        }

        public async Task<ApiResponse> SignUp(RegisterDto dto)
        {
            AppUser appUser = new AppUser()
            {
                Name = dto.Name,
                Surname = dto.Surname,
                Email = dto.Email,
                UserName = dto.UserName,
                UserPricingId = 1,
                CountryId = dto.CountryId
            };
            appUser.Image = dto.file.CreateImage(_evn.WebRootPath, "Images/Users");
            var result = await _userManager.CreateAsync(appUser, dto.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    return new ApiResponse
                    {
                        StatusCode = 404,
                        Description = error.Description
                    };
                }
            }
            await _userManager.AddToRoleAsync(appUser, "User");
            string token = await _userManager.GenerateEmailConfirmationTokenAsync(appUser);
            return new ApiResponse
            {
                items = appUser,
                StatusCode = 200,
                Token = token
            };

        }
        public async Task<ApiResponse> VerifyEmail(string token, string mail)
        {
            var user = await _userManager.FindByEmailAsync(mail);
            if (user is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                };
            }
            await _userManager.ConfirmEmailAsync(user, token);
            await _signInManager.SignInAsync(user, true);
            return new ApiResponse
            {
                StatusCode = 200,
            };
        }
        public async Task<ApiResponse> Login(LoginDto dto, bool UserStatus)
        {
            AppUser appUser = await _userManager.FindByEmailAsync(dto.Email);
            if (appUser is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Email or password is not correct"
                };
            }
            if (UserStatus)
            {
                if (!await _userManager.IsInRoleAsync(appUser, "User"))
                {
                    return new ApiResponse
                    {
                        StatusCode = 400,
                        Description = "Access Failed"
                    };
                }
            }
            else
            {
                if (!await _userManager.IsInRoleAsync(appUser, "Admin") && !await _userManager.IsInRoleAsync(appUser, "SuperAdmin"))
                {
                    return new ApiResponse
                    {
                        StatusCode = 400,
                        Description = "Access Failed"
                    };
                }
            }

            var result = await _signInManager.PasswordSignInAsync(appUser, dto.Password, dto.RememberMe, true);
            if (!result.Succeeded)
            {
                if (result.IsLockedOut)
                {
                    return new ApiResponse
                    {
                        StatusCode = 400,
                        Description = "Your account blocked 5 minutes"
                    };
                }
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Username or password is not correct "
                };
            }
            return new ApiResponse
            {
                StatusCode = 200,
                items = appUser
            };
        }
        public async Task<ApiResponse> LogOut()
        {
            await _signInManager.SignOutAsync();
            return new ApiResponse
            {
                StatusCode = 203
            };
        }
        public async Task<ApiResponse> ForgetPassword(string mail)
        {
            if (mail is null)
            {
                return new ApiResponse
                {
                    StatusCode = 400,
                    Description = "Please enter email"
                };
            }
            var user = await _userManager.FindByEmailAsync(mail);
            if (user is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                };
            }
            string token = await _userManager.GeneratePasswordResetTokenAsync(user);
            return new ApiResponse
            {
                StatusCode = 200,
                Token = token,
                items = user
            };
        }
        public async Task<ApiResponse> ResetPasswordGet(string mail, string token)
        {
            var user = await _userManager.FindByEmailAsync(mail);
            if (user is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                };
            }
            ResetPasswordDto dto = new ResetPasswordDto()
            {
                Mail = mail,
                Token = token
            };
            return new ApiResponse
            {
                StatusCode = 200,
                items = dto
            };
        }
        public async Task<ApiResponse> ResetPasswordPost(ResetPasswordDto dto)
        {
            var user = await _userManager.FindByEmailAsync(dto.Mail);
            string errors = "";
            if (user is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                };
            }
            var result = await _userManager.
               ResetPasswordAsync(user, dto.Token, dto.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    errors += error.Description;
                }
                return new ApiResponse
                {
                    StatusCode = 400,
                    Description = errors
                };
            }
            return new ApiResponse
            {
                StatusCode = 203
            };
        }
        public async Task<ApiResponse> Info()
        {
            AppUser appUser = await _userManager.Users.
    Include(x => x.Country).
    Include(x => x.UserPricing).
    Include(x => x.Cars)
    .Where(x => x.UserName == _http.HttpContext.User.Identity.Name).FirstOrDefaultAsync();
            if (!await _userManager.IsInRoleAsync(appUser, "User"))
            {
                return new ApiResponse
                {
                    StatusCode = 401,
                    Description = "You cannot see Admin Info"
                };
            }
            
            InfoVM infoVM = new InfoVM
            {
                AppUser = appUser
            };
            return new ApiResponse
            {
                StatusCode = 200,
                items = infoVM
            };
        }
        public async Task<ApiResponse> GetUser()
        {
            var user = await _userManager.Users.
                Include(x=>x.Country).
                Include(x=>x.UserPricing).
                Include(x=>x.Cars)
                .Where(x=>x.UserName==_http.HttpContext.User.Identity.Name).FirstOrDefaultAsync();
            if (user is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404
                };
            }
            if (await _userManager.IsInRoleAsync(user, "User"))
            {
                return new ApiResponse
                {
                    StatusCode = 203,
                    items = user,
                    itemView=user
                };
            }
            else
            {
                return new ApiResponse
                {
                    StatusCode = 203,
                    items = user,
                    itemView=null
                };
            }
          
        }
        public async Task<ApiResponse> Update(UpdateDto dto,AppUser? updated)
        {
            var user = await _userManager.FindByNameAsync(_http.HttpContext.User.Identity.Name);
            if(updated is not null)
            {
                user = updated;
            }
            if (user is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404
                };
            }
            if (dto.file is not null)
            {
                user.Image = dto.file.CreateImage(_evn.WebRootPath, "Images/Users");
            }
         
            if(dto.UserName is not null)
            {
                user.Name = dto.Name;
                user.Email = dto.Email;
                user.Surname = dto.Surname;
                user.UserName = dto.UserName;
                user.CountryId = dto.CountryId;
            }
            else
            {
                user.UserPricingId = dto.UserPricingId;
            }
            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    return new ApiResponse
                    {
                        StatusCode = 400,
                        Description = item.Description
                    };
                }
            }
            if (!string.IsNullOrWhiteSpace(dto.Password))
            {
                result = await _userManager.ChangePasswordAsync(user, dto.CurrentPassword, dto.Password);
                if (!result.Succeeded)
                {
                    foreach (var item in result.Errors)
                    {
                        return new ApiResponse
                        {
                            StatusCode = 400,
                            Description = item.Description
                        };
                    }
                }
            }
            if (updated is null)
            {
                await _signInManager.SignInAsync(user, true);
            }
            return new ApiResponse
            {
                StatusCode = 203
            };
        }
        public async Task<ApiResponse> GetAllUsers(int count,int page)
        {

            List<AppUser> users = new List<AppUser>();
            List<AppUser> allusers = new List<AppUser>();
            if (count != 0 && page != 0)
            {
                foreach (var user in await _userManager.Users.Include(x => x.Country).Include(x=>x.UserPricing).ToListAsync())
                {
                    if (await _userManager.IsInRoleAsync(user, "User"))
                    {
                        allusers.Add(user);
                    }
                }

                foreach (var user in  (List<AppUser>)allusers.Skip((page - 1) * count).Take(count).ToList())
                {
                        users.Add(user);
                }
            }
            else
            {
                foreach (var user in await _userManager.Users.Include(x => x.Country).Include(x => x.UserPricing).ToListAsync())
                {
                    if (await _userManager.IsInRoleAsync(user, "User"))
                    {
                        users.Add(user);
                    }
                }
            }
            return new ApiResponse
            {
                StatusCode = 200,
                items = users
            };
        }
        public async Task<ApiResponse> GetUserById(string id)
        {
            AppUser? appUser = await _userManager.FindByIdAsync(id);
            if (appUser is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404
                };
            }
            return new ApiResponse
            {
                StatusCode = 203,
                items = appUser
            };
        }
        public async Task<ApiResponse> GetAllAdmin(int count, int page)
        {
            var users = new List<AppUser>();
            if (count != 0)
            {
                users = await _userManager.Users.Skip((page - 1) * count).Take(count).ToListAsync();
            }
            else
            {
                users = await _userManager.Users.Include(x=>x.UserPricing).ToListAsync();

            }
            List<AppUser> admins = new List<AppUser>();
            foreach (var user in users)
            {
                if (await _userManager.IsInRoleAsync(user, "Admin"))
                {
                    admins.Add(user);
                }
            }
            return new ApiResponse
            {
                StatusCode = 203,
                items = admins
            };
        }
        public async Task<ApiResponse> Create(AppUser user, string password, bool isAdmin)
        {
            await _userManager.CreateAsync(user, password);

            if (isAdmin)
            {
                await _userManager.AddToRoleAsync(user, "Admin");

            }
            else
                await _userManager.AddToRoleAsync(user, "User");

            return new ApiResponse
            {
                StatusCode = 203,
            };
        }
        public async Task<ApiResponse> Remove(string id)
        {
            AppUser? appUser = await _userManager.FindByIdAsync(id);
            if (appUser is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404
                };
            }
            await _userManager.DeleteAsync(appUser);
            return new ApiResponse
            {
                StatusCode = 203,
            };
        }
    }
}
