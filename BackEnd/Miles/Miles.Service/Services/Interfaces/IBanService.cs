using Miles.Service.Dtos.Bans;
using Miles.Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Services.Interfaces
{
    public interface IBanService
    {
        public Task<ApiResponse> CreateAsync(BanPostDto dto);
        public Task<ApiResponse> GetAsync(int id);
        public Task<ApiResponse> GetAllAsync(int count, int page);
        public Task<ApiResponse> UpdateAsync(int id, BanUpdateDto dto);
        public Task<ApiResponse> RemoveAsync(int id);
    }
}
