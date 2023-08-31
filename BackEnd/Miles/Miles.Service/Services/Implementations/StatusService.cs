using AutoMapper;
using Miles.Core.Entities;
using Miles.Core.Repositories;
using Miles.Service.Dtos.Statuses;
using Miles.Service.Responses;
using Miles.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Services.Implementations
{
    public class StatusService : IStatusService
    {
        private readonly IStatusRepository _repository;
        private readonly IMapper _mapper;

        public StatusService(IStatusRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ApiResponse> CreateAsync(StatusPostDto dto)
        {
            if (await _repository.isExsist(x => x.Name.Trim().ToLower() == dto.Name.Trim().ToLower()))
            {
                return new ApiResponse
                {
                    StatusCode = 400,
                    Description = $"{dto.Name} Already exists"
                };
            }
            Status Status = _mapper.Map<Status>(dto);
            await _repository.AddAsync(Status);
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 201,
                items = Status
            };
        }

        public async Task<ApiResponse> GetAllAsync(int count,int page)
        {
            IEnumerable<Status> Statuss = await _repository.GetAllAsync(x => !x.IsDeleted,count,page,"Cars");
            return new ApiResponse
            {
                items = Statuss,
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int id)
        {
            Status Status = await _repository.GetAsync(x => !x.IsDeleted && x.Id == id);
            if (Status is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            StatusUpdateDto dto = _mapper.Map<StatusUpdateDto>(Status);

            return new ApiResponse
            {
                StatusCode = 200,
                items = dto
            };
        }

        public async Task<ApiResponse> RemoveAsync(int id)
        {
            Status Status = await _repository.GetAsync(x => x.Id == id);
            if (Status is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Status.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Status
            };
        }

        public async Task<ApiResponse> UpdateAsync(int id, StatusUpdateDto dto)
        {
            Status Status = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
            if (dto.Name != Status.Name)
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
            if (Status is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Status.UpdatedAt = DateTime.UtcNow.AddHours(4);
            Status.Name = dto.Name;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Status
            };
        }
    }
}
