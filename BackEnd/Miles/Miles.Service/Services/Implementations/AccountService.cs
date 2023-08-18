using Azure.Core;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Miles.Core.Entities;
using Miles.Service.Dtos.Accounts;
using Miles.Service.Extensions;
using Miles.Service.Responses;
using Miles.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Miles.Service.Services.Implementations
{
    public class AccountService:IAccountService
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
                UserPricingId = 1
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
        public async Task<ApiResponse> Login(LoginDto dto)
        {
            AppUser appUser = await _userManager.FindByEmailAsync(dto.Email);
            if (appUser is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Username or password is not correct"
                };
            }
            if (!await _userManager.IsInRoleAsync(appUser, "User"))
            {
                return new ApiResponse
                {
                    StatusCode = 400,
                    Description = "Access Failed"
                };
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
                StatusCode = 200
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
                items= dto
            };
        }
        public async Task<ApiResponse> ResetPasswordPost(ResetPasswordDto dto)
        {
            var user = await _userManager.FindByEmailAsync(dto.Mail);
            string errors = null;
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
                foreach(var error in result.Errors)
                {
                    errors += error;
                }
                return new ApiResponse
                {
                    StatusCode = 400,
                    Description = errors
                };
            }
            return new ApiResponse
            {
                StatusCode = 203,
            };
        }
        public async Task<ApiResponse> Info()
        {
            string username = _http.HttpContext.User.Identity.Name;
            AppUser appUser = await _userManager.FindByNameAsync(username);
            if (!await _userManager.IsInRoleAsync(appUser, "User"))
            {
                return new ApiResponse
                {
                    StatusCode = 401,
                    Description = "You cannot see Admin Info"
                };
            }
            return new ApiResponse
            {
                StatusCode = 200,
                items = appUser
            };
        }
        public async Task<ApiResponse> GetUser()
        {
            var user = await _userManager.FindByNameAsync(_http.HttpContext.User.Identity.Name);
            if (user is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404
                };
            }
            return new ApiResponse
            {
                StatusCode = 203
            };
        }
        public async Task<ApiResponse> Update(UpdateDto dto)
        {
            var user = await _userManager.FindByNameAsync(_http.HttpContext.User.Identity.Name);
            if (user is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404
                };
            }
            user.Name = dto.Name;
            user.Email = dto.Email;
            user.Surname = dto.Surname;
            user.UserName = dto.UserName;
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
            await _signInManager.SignInAsync(user, true);
            return new ApiResponse
            {
                StatusCode = 203
            };
        }

    }
}
