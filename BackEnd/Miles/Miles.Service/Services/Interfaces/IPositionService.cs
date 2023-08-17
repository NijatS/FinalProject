using Miles.Service.Dtos.Positions;
using Miles.Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Services.Interfaces
{
    public interface IPositionService
    {
        public Task<ApiResponse> CreateAsync(PositionPostDto dto);
        public Task<ApiResponse> GetAsync(int id);
        public Task<ApiResponse> GetAllAsync(int count, int page);
        public Task<ApiResponse> UpdateAsync(int id, PositionUpdateDto dto);
        public Task<ApiResponse> RemoveAsync(int id);
    }
}
