using AutoMapper;
using Miles.Core.Entities;
using Miles.Core.Repositories;
using Miles.Data.Repositories;
using Miles.Service.Dtos.Categories;
using Miles.Service.Dtos.Features;
using Miles.Service.Responses;
using Miles.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Services.Implementations
{
    public class FeatureService : IFeatureService
    {
        private readonly IFeatureRepository _repository;
        private readonly IMapper _mapper;

        public FeatureService(IFeatureRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ApiResponse> CreateAsync(FeaturePostDto dto)
        {
            Feature Feature = _mapper.Map<Feature>(dto);
            await _repository.AddAsync(Feature);
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 201,
                items = Feature
            };
        }

        public async Task<ApiResponse> GetAllAsync(int count,int page)
        {
            IEnumerable<Feature> Features = await _repository.GetAllAsync(x => !x.IsDeleted,count,page,"UserPricing");
            return new ApiResponse
            {
                items = Features,
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int id)
        {
            Feature Feature = await _repository.GetAsync(x => !x.IsDeleted && x.Id == id);
            if (Feature is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            FeatureUpdateDto dto = _mapper.Map<FeatureUpdateDto>(Feature);

            return new ApiResponse
            {
                StatusCode = 200,
                items = dto
            };
        }

        public async Task<ApiResponse> RemoveAsync(int id)
        {
            Feature Feature = await _repository.GetAsync(x => x.Id == id);
            if (Feature is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Feature.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Feature
            };
        }
        public async Task<ApiResponse> UpdateAsync(int id, FeatureUpdateDto dto)
        {
            Feature Feature = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
            if (Feature is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Feature.UpdatedAt = DateTime.UtcNow.AddHours(4);
            Feature.Name = dto.Name;
            Feature.Icon = dto.Icon;
            Feature.UserPricingId = dto.UserPricingId;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Feature
            };
        }
    }
}
