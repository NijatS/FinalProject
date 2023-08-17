using Miles.Service.Dtos.Staffs;
using Miles.Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Services.Interfaces
{
    public interface IStaffService
    {
        public Task<ApiResponse> CreateAsync(StaffPostDto dto);
        public Task<ApiResponse> GetAsync(int id);
        public Task<ApiResponse> GetAllAsync(int count, int page);
        public Task<ApiResponse> UpdateAsync(int id, StaffUpdateDto dto);
        public Task<ApiResponse> RemoveAsync(int id);
    }
}
