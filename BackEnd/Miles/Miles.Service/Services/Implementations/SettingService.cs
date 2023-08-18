﻿using AutoMapper;
using Miles.Core.Entities;
using Miles.Core.Repositories;
using Miles.Data.Repositories;
using Miles.Service.Dtos.Categories;
using Miles.Service.Dtos.Settings;
using Miles.Service.Responses;
using Miles.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miles.Service.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Miles.Service.Dtos.Blogs;
using Microsoft.EntityFrameworkCore;
using Miles.Service.ViewModels;

namespace Miles.Service.Services.Implementations
{
    public class SettingService : ISettingService
    {
        private readonly ISettingRepository _repository;
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;
		private readonly IWebHostEnvironment _evn;
		private readonly IHttpContextAccessor _http;
        private readonly IAccountService _accountService;

        public SettingService(ISettingRepository repository, IMapper mapper, IWebHostEnvironment evn, IHttpContextAccessor http, IBlogRepository blogRepository, IAccountService accountService)
        {
            _repository = repository;
            _mapper = mapper;
            _evn = evn;
            _http = http;
            _blogRepository = blogRepository;
            _accountService = accountService;
        }

        public async Task<ApiResponse> CreateAsync(SettingPostDto dto)
        {
            Setting Setting = _mapper.Map<Setting>(dto);
			Setting.Logo = dto.Logo.CreateImage(_evn.WebRootPath, "Images/Settings");
			Setting.PhotoWhy = dto.PhotoWhy.CreateImage(_evn.WebRootPath, "Images/Settings");
			Setting.LogoUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
				+ $"Images/Settings/{Setting.Logo}";
			Setting.PhotoWhyUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
				+ $"Images/Settings/{Setting.PhotoWhy}";
			await _repository.AddAsync(Setting);
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 201,
                items = Setting
            };
        }

        public async Task<ApiResponse> GetAllAsync(int count,int page)
        {
            IEnumerable<Setting> Settings = await _repository.GetAllAsync(x => !x.IsDeleted,count,page);
            return new ApiResponse
            {
                items = Settings,
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int? id)
        {
            Setting Setting = new Setting();
            if(id == null)
            {
                Setting = await _repository.GetAsync(x => !x.IsDeleted);
            }
            else
            {
                Setting = await _repository.GetAsync(x => !x.IsDeleted && x.Id == id);
            }
            if (Setting is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            SettingUpdateDto dto = _mapper.Map<SettingUpdateDto>(Setting);
        
            return new ApiResponse
            {
                StatusCode = 200,
                items = dto
            };
        }

        public async Task<ApiResponse> RemoveAsync(int id)
        {
            Setting Setting = await _repository.GetAsync(x => x.Id == id);
            if (Setting is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Setting.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Setting
            };
        }
        public async Task<ApiResponse> UpdateAsync(int id, SettingUpdateDto dto)
        {
            Setting Setting = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
			if (dto.fileLogo is not null)
			{
				Setting.Logo = dto.fileLogo.CreateImage(_evn.WebRootPath, "Images/Settings");
				Setting.LogoUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
				+ $"Images/Settings/{Setting.Logo}";
			}
            if(dto.file is not null)
            {
				Setting.PhotoWhy = dto.file.CreateImage(_evn.WebRootPath, "Images/Settings");

				Setting.PhotoWhyUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
					+ $"Images/Settings/{Setting.PhotoWhy}";
			}
			if (Setting is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Setting.UpdatedAt = DateTime.UtcNow.AddHours(4);
            Setting.Address = dto.Address;
            Setting.Phone1 = dto.Phone1;
			Setting.Phone2 = dto.Phone2;
            Setting.Email = dto.Email;
			await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Setting
            };
        }
        public async Task<SettingVM> GetSetting()
        {
            SettingVM settingVM = new SettingVM
            {
                Setting = await _repository
                         .GetAsync(x => !x.IsDeleted, "Socials"),
                Blogs = await _blogRepository.GetAllAsync(x => !x.IsDeleted, 0, 0).Result.ToListAsync(),
                
            };
            if (_http.HttpContext.User.Identity.IsAuthenticated)
            {
                var result = await _accountService.GetUser();
                settingVM.AppUser = (AppUser)result.items;
            }

            return settingVM;
        }
    }
}
