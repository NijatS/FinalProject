using AutoMapper;
using Miles.Core.Entities;
using Miles.Core.Repositories;
using Miles.Service.Dtos.Subscribes;
using Miles.Service.Responses;
using Miles.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Services.Implementations
{
    public class SubscribeService : ISubscribeService
    {
        private readonly ISubscribeRepository _repository;
        private readonly IMapper _mapper;

        public SubscribeService(ISubscribeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<ApiResponse> CreateAsync(SubscribePostDto dto)
        {
            if (await _repository.isExsist(x => x.Email.Trim().ToLower() == dto.Email.Trim().ToLower()))
            {
                return new ApiResponse
                {
                    StatusCode = 400,
                    Description = $"{dto.Email} Already exists"
                };
            }
            Subscribe Subscribe = _mapper.Map<Subscribe>(dto);
            await _repository.AddAsync(Subscribe);
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 201,
                items = Subscribe
            };
        }

        public async Task<ApiResponse> GetAllAsync(int count,int page)
        {
            IEnumerable<Subscribe> Subscribes = await _repository.GetAllAsync(x => !x.IsDeleted,count,page);
            return new ApiResponse
            {
                items = Subscribes,
                StatusCode = 200
            };
        }
        public async Task<ApiResponse> RemoveAsync(int id)
        {
            Subscribe Subscribe = await _repository.GetAsync(x => x.Id == id);
            if (Subscribe is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Subscribe.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Subscribe
            };
        }
    }
}
