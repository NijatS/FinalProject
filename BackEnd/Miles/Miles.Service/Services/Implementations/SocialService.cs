using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Miles.Core.Entities;
using Miles.Core.Repositories;
using Miles.Data.Repositories;
using Miles.Service.Dtos.Categories;
using Miles.Service.Dtos.Socials;
using Miles.Service.Responses;
using Miles.Service.Services.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Services.Implementations
{
    public class SocialService : ISocialService
    {
        private readonly ISocialRepository _repository;
		private readonly ISettingRepository _settingRepository;
        private readonly IStaffRepository _staffRepository;
		private readonly IMapper _mapper;

        public SocialService(ISocialRepository repository, IMapper mapper, ISettingRepository settingRepository, IStaffRepository staffRepository)
        {
            _repository = repository;
            _mapper = mapper;
            _settingRepository = settingRepository;
            _staffRepository = staffRepository;
        }

        public async Task<ApiResponse> CreateAsync(SocialPostDto dto)
        {
            Social Social = _mapper.Map<Social>(dto);
			if (dto.StaffId == 0 && dto.SettingId == 0)
			{
				return new ApiResponse
				{
					StatusCode = 400,
					Description = "Teacher or Setting Id must be selected"
				};
			}
			if (dto.StaffId == 0)
			{
				Social.StaffId = null;
                Social.SettingId = _settingRepository.GetAsync(x => !x.IsDeleted).Result.Id;
			}
			await _repository.AddAsync(Social);
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 201,
                items = Social
            };
        }

        public async Task<ApiResponse> GetAllAsync(int count,int page)
        {
            IEnumerable<Social> Socials = await _repository.GetAllAsync(x => !x.IsDeleted,count,page,"Staff");
            return new ApiResponse
            {
                items = Socials,
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int id)
        {
            Social Social = await _repository.GetAsync(x => !x.IsDeleted && x.Id == id);
            if (Social is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            SocialUpdateDto dto = _mapper.Map<SocialUpdateDto>(Social);

            return new ApiResponse
            {
                StatusCode = 200,
                items = dto
            };
        }

        public async Task<ApiResponse> RemoveAsync(int id)
        {
            Social Social = await _repository.GetAsync(x => x.Id == id);
            if (Social is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Social.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Social
            };
        }

        public async Task<ApiResponse> UpdateAsync(int id, SocialUpdateDto dto)
        {
           
            Social Social = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
			if (dto.StaffId == 0 && dto.SettingId == 0)
			{
				return new ApiResponse
				{
					StatusCode = 400,
					Description = "Teacher or Setting Id must be selected"
				};
			}
            if (dto.StaffId == 0)
            {
                Social.StaffId = null;
                Social.SettingId = _settingRepository.GetAsync(x => !x.IsDeleted).Result.Id;
            }
			if (Social is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Social.UpdatedAt = DateTime.UtcNow.AddHours(4);
            Social.Icon = dto.Icon;
			Social.Link = dto.Link;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Social
            };
        }
    }
}
