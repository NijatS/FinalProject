using AutoMapper;
using Miles.Core.Entities;
using Miles.Core.Repositories;
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
using Miles.Service.Dtos.Countries;

namespace Miles.Service.Services.Implementations
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _repository;
        private readonly IMapper _mapper;
		private readonly IWebHostEnvironment _evn;
		private readonly IHttpContextAccessor _http;

		public CountryService(ICountryRepository repository, IMapper mapper, IWebHostEnvironment evn, IHttpContextAccessor http)
		{
			_repository = repository;
			_mapper = mapper;
			_evn = evn;
			_http = http;
		}

		public async Task<ApiResponse> CreateAsync(CountryPostDto dto)
        {
            if (await _repository.isExsist(x => x.Name.Trim().ToLower() == dto.Name.Trim().ToLower()))
            {
                return new ApiResponse
                {
                    StatusCode = 400,
                    Description = $"{dto.Name} Already exists"
                };
            }
            Country Country = _mapper.Map<Country>(dto);
			Country.FlagImage = dto.file.CreateImage(_evn.WebRootPath, "Images/Countries");
			Country.FlagUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
				+ $"Images/Countries/{Country.FlagImage}";
			await _repository.AddAsync(Country);
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 201,
                items = Country
            };
        }

        public async Task<ApiResponse> GetAllAsync(int count,int page)
        {
            IEnumerable<Country> Countrys = await _repository.GetAllAsync(x => !x.IsDeleted,count,page);
            return new ApiResponse
            {
                items = Countrys,
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int id)
        {
            Country Country = await _repository.GetAsync(x => !x.IsDeleted && x.Id == id);
            if (Country is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            CountryUpdateDto dto = _mapper.Map<CountryUpdateDto>(Country);

            return new ApiResponse
            {
                StatusCode = 200,
                items = dto,
                itemView = Country
            };
        }

        public async Task<ApiResponse> RemoveAsync(int id)
        {
            Country Country = await _repository.GetAsync(x => x.Id == id);
            if (Country is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Country.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Country
            };
        }

        public async Task<ApiResponse> UpdateAsync(int id, CountryUpdateDto dto)
        {
           
            Country Country = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
			if (dto.Name != Country.Name)
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
				Country.FlagImage = dto.file.CreateImage(_evn.WebRootPath, "Images/Countries");
				Country.FlagUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
					+ $"Images/Countries/{Country.FlagImage}";
			}
			if (Country is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Country.UpdatedAt = DateTime.UtcNow.AddHours(4);
            Country.Name = dto.Name;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Country
            };
        }
    }
}
