using AutoMapper;
using Miles.Core.Entities;
using Miles.Core.Repositories;
using Miles.Data.Repositories;
using Miles.Service.Dtos.Categories;
using Miles.Service.Dtos.Sliders;
using Miles.Service.Responses;
using Miles.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miles.Service.Extensions;
using static System.Net.WebRequestMethods;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Miles.Service.Services.Implementations
{
    public class SliderService : ISliderService
    {
        private readonly ISliderRepository _repository;
        private readonly IMapper _mapper;
		private readonly IWebHostEnvironment _evn;
		private readonly IHttpContextAccessor _http;

		public SliderService(ISliderRepository repository, IMapper mapper, IWebHostEnvironment evn, IHttpContextAccessor http)
		{
			_repository = repository;
			_mapper = mapper;
			_evn = evn;
			_http = http;
		}

		public async Task<ApiResponse> CreateAsync(SliderPostDto dto)
        {
            Slider Slider = _mapper.Map<Slider>(dto);
			Slider.Image = dto.file.CreateImage(_evn.WebRootPath, "Images/Sliders");
			Slider.ImageUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
				+ $"Images/Sliders/{Slider.Image}";
			await _repository.AddAsync(Slider);
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 201,
                items = Slider
            };
        }

        public async Task<ApiResponse> GetAllAsync(int count,int page)
        {
            IEnumerable<Slider> Sliders = await _repository.GetAllAsync(x => !x.IsDeleted,count,page);
            return new ApiResponse
            {
                items = Sliders,
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int id)
        {
            Slider Slider = await _repository.GetAsync(x => !x.IsDeleted && x.Id == id);
            if (Slider is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            SliderUpdateDto dto = _mapper.Map<SliderUpdateDto>(Slider);

            return new ApiResponse
            {
                StatusCode = 200,
                items = dto
            };
        }

        public async Task<ApiResponse> RemoveAsync(int id)
        {
            Slider Slider = await _repository.GetAsync(x => x.Id == id);
            if (Slider is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Slider.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Slider
            };
        }
        public async Task<ApiResponse> UpdateAsync(int id, SliderUpdateDto dto)
        {
           
            Slider Slider = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
			
			if (dto.file is not null)
			{
				Slider.Image = dto.file.CreateImage(_evn.WebRootPath, "Images/Sliders");
				Slider.ImageUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
					+ $"Images/Sliders/{Slider.Image}";
			}
			if (Slider is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Slider.UpdatedAt = DateTime.UtcNow.AddHours(4);
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Slider
            };
        }
    }
}
