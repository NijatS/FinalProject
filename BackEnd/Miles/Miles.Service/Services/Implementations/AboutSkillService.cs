using AutoMapper;
using Miles.Core.Entities;
using Miles.Core.Repositories;
using Miles.Data.Repositories;
using Miles.Service.Dtos.Categories;
using Miles.Service.Dtos.AboutSkills;
using Miles.Service.Responses;
using Miles.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Services.Implementations
{
    public class AboutSkillService : IAboutSkillService
    {
        private readonly IAboutSkillRepository _repository;
        private readonly IMapper _mapper;

        public AboutSkillService(IAboutSkillRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ApiResponse> CreateAsync(AboutSkillPostDto dto)
        {

			if (await _repository.isExsist(x => x.Name.Trim().ToLower() == dto.Name.Trim().ToLower()))
			{
				return new ApiResponse
				{
					StatusCode = 400,
					Description = $"{dto.Name} Already exists"
				};
			}
			AboutSkill AboutSkill = _mapper.Map<AboutSkill>(dto);

            await _repository.AddAsync(AboutSkill);
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 201,
                items = AboutSkill
            };
        }

        public async Task<ApiResponse> GetAllAsync(int count,int page)
        {
            IEnumerable<AboutSkill> AboutSkills = await _repository.GetAllAsync(x => !x.IsDeleted,count,page);
            return new ApiResponse
            {
                items = AboutSkills,
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int id)
        {
            AboutSkill AboutSkill = await _repository.GetAsync(x => !x.IsDeleted && x.Id == id);
            if (AboutSkill is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            AboutSkillUpdateDto dto = _mapper.Map<AboutSkillUpdateDto>(AboutSkill);

            return new ApiResponse
            {
                StatusCode = 200,
                items = dto
            };
        }

        public async Task<ApiResponse> RemoveAsync(int id)
        {
            AboutSkill AboutSkill = await _repository.GetAsync(x => x.Id == id);
            if (AboutSkill is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            AboutSkill.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = AboutSkill
            };
        }
        public async Task<ApiResponse> UpdateAsync(int id, AboutSkillUpdateDto dto)
        {
			AboutSkill AboutSkill = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
            if (dto.Name != AboutSkill.Name)
            {
                if (await _repository.isExsist(x => x.Name.Trim().ToLower() == dto.Name.Trim().ToLower()))
                {
                    return new ApiResponse
                    {
                        StatusCode = 400,
                        Description = $"{dto.Name} Already exists"
                    };
                }
            }
            if (AboutSkill is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            AboutSkill.UpdatedAt = DateTime.UtcNow.AddHours(4);
            AboutSkill.Name = dto.Name;
            AboutSkill.Degree = dto.Degree;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = AboutSkill
            };
        }
    }
}
