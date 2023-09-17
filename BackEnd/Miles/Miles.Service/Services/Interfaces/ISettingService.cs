using Miles.Core.Entities;
using Miles.Service.Dtos.Settings;
using Miles.Service.Responses;
using Miles.Service.Services.Implementations;
using Miles.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;
using Telegram.Bot;
using Telegram.Bot.Types;
using ApiResponse = Miles.Service.Responses.ApiResponse;

namespace Miles.Service.Services.Interfaces
{
    public interface ISettingService
    {
        public Task<ApiResponse> CreateAsync(SettingPostDto dto);
        public Task<ApiResponse> GetAsync(int? id);
        public Task<ApiResponse> GetAllAsync(int count,int page);
        public Task<ApiResponse> UpdateAsync(int id, SettingUpdateDto dto);
        public Task<ApiResponse> RemoveAsync(int id);
        public Task<SettingVM> GetSetting();
    }
}
