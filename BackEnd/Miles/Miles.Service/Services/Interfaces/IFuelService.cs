using Miles.Service.Dtos.Fuels;
using Miles.Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Services.Interfaces
{
    public interface IFuelService
    {
        public Task<ApiResponse> CreateAsync(FuelPostDto dto);
        public Task<ApiResponse> GetAsync(int id);
        public Task<ApiResponse> GetAllAsync(int count, int page);
        public Task<ApiResponse> UpdateAsync(int id, FuelUpdateDto dto);
        public Task<ApiResponse> RemoveAsync(int id);
    }
}
