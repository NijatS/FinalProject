using Miles.Core.Entities;
using Miles.Core.Repositories;
using Miles.Service.Responses;
using Miles.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Miles.Service.Services.Implementations
{
    public class CarImageService : ICarImageService
    {
        private readonly ICarImageRepository _repository;

        public CarImageService(ICarImageRepository repository)
        {
            _repository = repository;
        }

        public async Task<ApiResponse> GetAllAsync(int count,int page, Expression<Func<CarImage, bool>>? expression)
        {
            IEnumerable<CarImage> CarImages = new List<CarImage>();
            if (expression is null)
            {
               CarImages = await _repository.GetAllAsync(x => !x.IsDeleted, count, page);
            }
            else
            {
               CarImages = await _repository.GetAllAsync(expression, count, page);
            }
        
            return new ApiResponse
            {
                items = CarImages,
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int id, Expression<Func<CarImage, bool>>? expression)
        {
            CarImage CarImage = null;
            if (expression is null)
            {
                 CarImage = await _repository.GetAsync(x => !x.IsDeleted && x.Id == id);
            }
            else
            {
                CarImage = await _repository.GetAsync(expression);
            }
            if (CarImage is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
			return new ApiResponse
            {
                StatusCode = 200,
                itemView = CarImage
            };
           

        }
        public async Task<ApiResponse> Save()
        {
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 203,
            };
        }
    }
}
