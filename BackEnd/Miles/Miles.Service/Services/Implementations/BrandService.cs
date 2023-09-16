using AutoMapper;
using Miles.Core.Entities;
using Miles.Core.Repositories;
using Miles.Service.Dtos.Brands;
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
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _repository;
        private readonly IMapper _mapper;
		private readonly IWebHostEnvironment _evn;
		private readonly IHttpContextAccessor _http;

		public BrandService(IBrandRepository repository, IMapper mapper, IWebHostEnvironment evn, IHttpContextAccessor http)
		{
			_repository = repository;
			_mapper = mapper;
			_evn = evn;
			_http = http;
		}

		public async Task<ApiResponse> CreateAsync(BrandPostDto dto)
        {
            if (await _repository.isExsist(x => x.Name.Trim().ToLower() == dto.Name.Trim().ToLower()))
            {
                return new ApiResponse
                {
                    StatusCode = 400,
                    Description = $"{dto.Name} Already exists"
                };
            }
            Brand Brand = _mapper.Map<Brand>(dto);
			Brand.Image = dto.file.CreateImage(_evn.WebRootPath, "Images/Brands");
			Brand.ImageUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
				+ $"Images/Brands/{Brand.Image}";
			await _repository.AddAsync(Brand);
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 201,
                items = Brand
            };
        }

        public async Task<ApiResponse> GetAllAsync(int count,int page)
        {
            IEnumerable<Brand> Brands = await _repository.GetAllAsync(x => !x.IsDeleted,count,page);
            return new ApiResponse
            {
                items = Brands.OrderBy(x=>x.Name),
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int id)
        {
            Brand Brand = await _repository.GetAsync(x => !x.IsDeleted && x.Id == id);
            if (Brand is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            BrandUpdateDto dto = _mapper.Map<BrandUpdateDto>(Brand);

            return new ApiResponse
            {
                StatusCode = 200,
                items = dto,
                itemView=Brand
            };
        }

        public async Task<ApiResponse> RemoveAsync(int id)
        {
            Brand Brand = await _repository.GetAsync(x => x.Id == id);
            if (Brand is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Brand.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Brand
            };
        }

        public async Task<ApiResponse> UpdateAsync(int id, BrandUpdateDto dto)
        {
           
            Brand Brand = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
			if (dto.Name != Brand.Name)
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
				Brand.Image = dto.file.CreateImage(_evn.WebRootPath, "Images/Brands");
				Brand.ImageUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
					+ $"Images/Brands/{Brand.Image}";
			}
			if (Brand is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Brand.UpdatedAt = DateTime.UtcNow.AddHours(4);
            Brand.Name = dto.Name;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Brand
            };
        }
    }
}
