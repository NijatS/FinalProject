using AutoMapper;
using Miles.Core.Entities;
using Miles.Core.Repositories;
using Miles.Data.Repositories;
using Miles.Service.Dtos.Categories;
using Miles.Service.Dtos.Staffs;
using Miles.Service.Responses;
using Miles.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miles.Service.Extensions;
using static System.Net.WebRequestMethods;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Miles.Service.Dtos.Blogs;

namespace Miles.Service.Services.Implementations
{
    public class StaffService : IStaffService
    {
        private readonly IStaffRepository _repository;
        private readonly IMapper _mapper;
		private readonly IWebHostEnvironment _evn;
		private readonly IHttpContextAccessor _http;

		public StaffService(IStaffRepository repository, IMapper mapper, IWebHostEnvironment evn, IHttpContextAccessor http)
		{
			_repository = repository;
			_mapper = mapper;
			_evn = evn;
			_http = http;
		}

		public async Task<ApiResponse> CreateAsync(StaffPostDto dto)
        {
            Staff Staff = _mapper.Map<Staff>(dto);
			Staff.Image = dto.file.CreateImage(_evn.WebRootPath, "Images/Staffs");
			Staff.ImageUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
				+ $"Images/Staffs/{Staff.Image}";
			await _repository.AddAsync(Staff);
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 201,
                items = Staff
            };
        }

        public async Task<ApiResponse> GetAllAsync(int count,int page)
        {
            IEnumerable<Staff> Staffs = await _repository.GetAllAsync(x => !x.IsDeleted,count,page,"Position","Socials");
            return new ApiResponse
            {
                items = Staffs,
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int id)
        {
            Staff Staff = await _repository.GetAsync(x => !x.IsDeleted && x.Id == id);
            if (Staff is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            StaffUpdateDto dto = _mapper.Map<StaffUpdateDto>(Staff);
        
            return new ApiResponse
            {
                StatusCode = 200,
                items = dto
            };
        }

        public async Task<ApiResponse> RemoveAsync(int id)
        {
            Staff Staff = await _repository.GetAsync(x => x.Id == id);
            if (Staff is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Staff.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Staff
            };
        }
        public async Task<ApiResponse> UpdateAsync(int id, StaffUpdateDto dto)
        {
            Staff Staff = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
			if (dto.file is not null)
			{
                Staff.Image = dto.file.CreateImage(_evn.WebRootPath, "Images/Staffs");
                Staff.ImageUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
                    + $"Images/Staffs/{Staff.Image}";
            }
			if (Staff is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Staff.UpdatedAt = DateTime.UtcNow.AddHours(4);
            Staff.FullName = dto.FullName;
            Staff.PositionId = dto.PositionId;
			Staff.Info = dto.Info;
			await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Staff
            };
        }
    }
}
