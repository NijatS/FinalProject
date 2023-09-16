using AutoMapper;
using Miles.Core.Entities;
using Miles.Core.Repositories;
using Miles.Data.Repositories;
using Miles.Service.Dtos.Categories;
using Miles.Service.Dtos.Fuels;
using Miles.Service.Responses;
using Miles.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Services.Implementations
{
    public class FuelService : IFuelService
    {
        private readonly IFuelRepository _repository;
        private readonly IMapper _mapper;

        public FuelService(IFuelRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ApiResponse> CreateAsync(FuelPostDto dto)
        {
            if (await _repository.isExsist(x => x.Name.Trim().ToLower() == dto.Name.Trim().ToLower()))
            {
                return new ApiResponse
                {
                    StatusCode = 400,
                    Description = $"{dto.Name} Already exists"
                };
            }
            Fuel Fuel = _mapper.Map<Fuel>(dto);
            await _repository.AddAsync(Fuel);
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 201,
                items = Fuel
            };
        }

        public async Task<ApiResponse> GetAllAsync(int count,int page)
        {
            IEnumerable<Fuel> Fuels = await _repository.GetAllAsync(x => !x.IsDeleted,count,page);
            return new ApiResponse
            {
                items = Fuels.OrderBy(x => x.Name),
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int id)
        {
            Fuel Fuel = await _repository.GetAsync(x => !x.IsDeleted && x.Id == id);
            if (Fuel is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            FuelUpdateDto dto = _mapper.Map<FuelUpdateDto>(Fuel);

            return new ApiResponse
            {
                StatusCode = 200,
                items = dto
            };
        }

        public async Task<ApiResponse> RemoveAsync(int id)
        {
            Fuel Fuel = await _repository.GetAsync(x => x.Id == id);
            if (Fuel is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Fuel.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Fuel
            };
        }

        public async Task<ApiResponse> UpdateAsync(int id, FuelUpdateDto dto)
        {
          
            Fuel Fuel = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
            if (Fuel.Name.ToLower() != dto.Name.ToLower())
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
            if (Fuel is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Fuel.UpdatedAt = DateTime.UtcNow.AddHours(4);
            Fuel.Name = dto.Name;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Fuel
            };
        }
    }
}
