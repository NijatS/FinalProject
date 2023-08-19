using AutoMapper;
using Miles.Core.Entities;
using Miles.Core.Repositories;
using Miles.Data.Repositories;
using Miles.Service.Dtos.Categories;
using Miles.Service.Responses;
using Miles.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ApiResponse> CreateAsync(CategoryPostDto dto)
        {
            if (await _repository.isExsist(x => x.Name.Trim().ToLower() == dto.Name.Trim().ToLower()))
            {
                return new ApiResponse
                {
                    StatusCode = 400,
                    Description = $"{dto.Name} Already exists"
                };
            }
            Category category = _mapper.Map<Category>(dto);
            await _repository.AddAsync(category);
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 201,
                items = category
            };
        }

        public async Task<ApiResponse> GetAllAsync(int count,int page)
        {
            IEnumerable<Category> categories = await _repository.GetAllAsync(x => !x.IsDeleted,count,page,"BlogCategories");
            return new ApiResponse
            {
                items = categories,
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int id)
        {
            Category category = await _repository.GetAsync(x => !x.IsDeleted && x.Id == id);
            if (category is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            CategoryUpdateDto dto = _mapper.Map<CategoryUpdateDto>(category);

            return new ApiResponse
            {
                StatusCode = 200,
                items = dto
            };
        }

        public async Task<ApiResponse> RemoveAsync(int id)
        {
            Category category = await _repository.GetAsync(x => x.Id == id);
            if (category is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            category.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = category
            };
        }

        public async Task<ApiResponse> UpdateAsync(int id, CategoryUpdateDto dto)
        {
            if (await _repository.isExsist(x => x.Name.Trim().ToLower() == dto.Name.Trim().ToLower()))
            {
                return new ApiResponse
                {
                    StatusCode = 400,
                    Description = $"{dto.Name} Already exists"
                };
            }
            Category category = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
            if (category is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            category.UpdatedAt = DateTime.UtcNow.AddHours(4);
            category.Name = dto.Name;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = category
            };
        }
    }
}
