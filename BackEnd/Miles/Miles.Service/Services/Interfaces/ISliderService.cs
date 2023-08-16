using Miles.Service.Dtos.Sliders;
using Miles.Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Services.Interfaces
{
    public interface ISliderService
    {
        public Task<ApiResponse> CreateAsync(SliderPostDto dto);
        public Task<ApiResponse> GetAsync(int id);
        public Task<ApiResponse> GetAllAsync(int count, int page);
        public Task<ApiResponse> UpdateAsync(int id, SliderUpdateDto dto);
        public Task<ApiResponse> RemoveAsync(int id);
    }
}
