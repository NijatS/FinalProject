using Miles.Service.Dtos.Subscribes;
using Miles.Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Services.Interfaces
{
    public interface ISubscribeService
    {
        public Task<ApiResponse> CreateAsync(SubscribePostDto dto);
        public Task<ApiResponse> GetAllAsync(int count,int page);
        public Task<ApiResponse> RemoveAsync(int id);
    }
}
