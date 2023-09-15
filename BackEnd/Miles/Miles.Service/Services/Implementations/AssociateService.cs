using AutoMapper;
using Miles.Core.Entities;
using Miles.Core.Repositories;
using Miles.Service.Dtos.Associates;
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

namespace Miles.Service.Services.Implementations
{
    public class AssociateService : IAssociateService
    {
        private readonly IAssociateRepository _repository;
        private readonly IMapper _mapper;
		private readonly IWebHostEnvironment _evn;
		private readonly IHttpContextAccessor _http;

		public AssociateService(IAssociateRepository repository, IMapper mapper, IWebHostEnvironment evn, IHttpContextAccessor http)
		{
			_repository = repository;
			_mapper = mapper;
			_evn = evn;
			_http = http;
		}

		public async Task<ApiResponse> CreateAsync(AssociatePostDto dto)
        {
            if (await _repository.isExsist(x => x.Name.Trim().ToLower() == dto.Name.Trim().ToLower()))
            {
                return new ApiResponse
                {
                    StatusCode = 400,
                    Description = $"{dto.Name} Already exists"
                };
            }
            Associate Associate = _mapper.Map<Associate>(dto);
			Associate.Image = dto.file.CreateImage(_evn.WebRootPath, "Images/Associates");
			Associate.ImageUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
				+ $"Images/Associates/{Associate.Image}";
			await _repository.AddAsync(Associate);
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 201,
                items = Associate
            };
        }

        public async Task<ApiResponse> GetAllAsync(int count,int page)
        {
            IEnumerable<Associate> Associates = await _repository.GetAllAsync(x => !x.IsDeleted,count,page);
            return new ApiResponse
            {
                items = Associates,
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int id)
        {
            Associate Associate = await _repository.GetAsync(x => !x.IsDeleted && x.Id == id);
            if (Associate is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            AssociateUpdateDto dto = _mapper.Map<AssociateUpdateDto>(Associate);

            return new ApiResponse
            {
                StatusCode = 200,
                items = dto
            };
        }

        public async Task<ApiResponse> RemoveAsync(int id)
        {
            Associate Associate = await _repository.GetAsync(x => x.Id == id);
            if (Associate is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Associate.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Associate
            };
        }

        public async Task<ApiResponse> UpdateAsync(int id, AssociateUpdateDto dto)
        {
           
            Associate Associate = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
			if (dto.Name.ToLower() != Associate.Name.ToLower())
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
			if (dto.file is not null)
			{
				Associate.Image = dto.file.CreateImage(_evn.WebRootPath, "Images/Associates");
				Associate.ImageUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
					+ $"Images/Associates/{Associate.Image}";
			}
			if (Associate is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Associate.UpdatedAt = DateTime.UtcNow.AddHours(4);
            Associate.Name = dto.Name;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Associate
            };
        }
    }
}
