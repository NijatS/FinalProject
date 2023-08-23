using AutoMapper;
using Miles.Core.Entities;
using Miles.Core.Repositories;
using Miles.Service.Dtos.Cars;
using Miles.Service.Responses;
using Miles.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Miles.Service.Extensions;
using Microsoft.EntityFrameworkCore;
using Miles.Data.Context;
using System.Linq.Expressions;
using Microsoft.Extensions.Hosting;
using Miles.Service.Helpers;

namespace Miles.Service.Services.Implementations
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _repository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _evn;
        private readonly IHttpContextAccessor _http;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ITagRepository _tagRepository;
        private readonly MilesAppDbContext _context;
		public CarService(ICarRepository repository, IMapper mapper, IWebHostEnvironment evn, IHttpContextAccessor http, ICategoryRepository categoryRepository, ITagRepository tagRepository, MilesAppDbContext context)
		{
			_repository = repository;
			_mapper = mapper;
			_evn = evn;
			_http = http;
			_categoryRepository = categoryRepository;
			_tagRepository = tagRepository;
			_context = context;
		}
		public async Task<ApiResponse> CreateAsync(CarPostDto dto)
        {
            int i = 0;
            Car Car = _mapper.Map<Car>(dto);
            foreach (var item in dto.FormFiles)
            {
                CarImage carImage = new CarImage
                {
                    Car = Car,
                    Image = item.CreateImage(_evn.WebRootPath, "Images/Cars"),
                    isMain = i == 0 ? true : false,
                };
                carImage.ImageUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
                      + $"Images/Cars/{carImage.Image}";
                await _context.CarImages.AddAsync(carImage);
                i++;
            }
            await _repository.AddAsync(Car);
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 201,
                items = Car
            };
        }
        public async Task<ApiResponse> GetAllAsync(int count,int page, Expression<Func<Car, bool>>? expression)
        {
            IEnumerable<Car> Cars = new List<Car>();
            if (expression is null)
            {
               Cars = await _repository.GetAllAsync(x => !x.IsDeleted, count, page, "Fuel","Ban");
            }
            else
            {
               Cars = await _repository.GetAllAsync(expression, count, page, "Fuel", "Ban");

            }
            return new ApiResponse
            {
                items = Cars,
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int id)
        {
            Car Car = await _repository.GetAsync(x => !x.IsDeleted && x.Id == id, "CarCategories","CarTags", "Comments");
            if (Car is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            CarUpdateDto dto = _mapper.Map<CarUpdateDto>(Car);
			return new ApiResponse
            {
                StatusCode = 200,
                items = dto,
                itemView = Car
            };
        }

        public async Task<ApiResponse> RemoveAsync(int id)
        {
            Car Car = await _repository.GetAsync(x => x.Id == id);
            if (Car is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Car.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Car
            };
        }

        public async Task<ApiResponse> UpdateAsync(int id, CarUpdateDto dto)
        {
			Car Car = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted, "CarCategories", "CarTags");
			if (Car is null)
			{
				return new ApiResponse
				{
					StatusCode = 404,
					Description = "Not found"
				};
			}
            if (dto.FormFiles is not null && dto.FormFiles.Count > 0)
            {
                foreach (var item in dto.FormFiles)
                {
                    CarImage carImage = new CarImage
                    {
                        Car = Car,
                        Image = item.CreateImage(_evn.WebRootPath, "Images/Cars"),
                    };
                    carImage.ImageUrl = _http.HttpContext?.Request.Scheme + "://" + _http.HttpContext?.Request.Host
                                      + $"Images/Cars/{carImage.Image}";
                    await _context.CarImages.AddAsync(carImage);
                }
            }
			
			Car.UpdatedAt = DateTime.UtcNow.AddHours(4);
			Car.Vin = dto.Vin;
            Car.ModelId = dto.ModelId;
            Car.FabricationYear = dto.FabricationYear;
            Car.Odometer = dto.Odometer;
            Car.FuelId = dto.FuelId;
            Car.NoGears = dto.NoGears;
            Car.Transmission = dto.Transmission;
            Car.FuelCity = dto.FuelCity;
            Car.FuelWay = dto.FuelWay;
            Car.Motor = dto.Motor;
            Car.ColorId = dto.ColorId;
            Car.Description = dto.Description;
			Car.Price = dto.Price;
			Car.AppUserId = dto.AppUserId;
            Car.BanId = dto.BanId;
			await _repository.SaveAsync();
			return new ApiResponse
			{
				StatusCode = 200,
				items = Car
			};

		}
    }
}
