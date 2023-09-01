using Miles.Core.Entities;
using Miles.Service.Dtos.Accounts;
using Miles.Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Services.Interfaces
{
    public interface IAccountService
    {
        public Task<ApiResponse> SignUp(RegisterDto dto);
        public Task<ApiResponse> VerifyEmail(string token, string mail);
        public Task<ApiResponse> Login(LoginDto dto, bool UserStatus);
        public Task<ApiResponse> LogOut();
        public Task<ApiResponse> ForgetPassword(string mail);
        public Task<ApiResponse> ResetPasswordGet(string mail, string token);
        public Task<ApiResponse> ResetPasswordPost(ResetPasswordDto dto);
        public Task<ApiResponse> Info();
        public Task<ApiResponse> GetUser();
        public Task<ApiResponse> Create(AppUser user, string password, bool isAdmin);
        public Task<ApiResponse> Update(UpdateDto dto, AppUser? updated);
        public Task<ApiResponse> GetAllUsers(int count, int page);
        public Task<ApiResponse> GetAllAdmin(int count, int page);
        public Task<ApiResponse> GetUserById(string id);
        public Task<ApiResponse> Remove(string id);

    }
}
