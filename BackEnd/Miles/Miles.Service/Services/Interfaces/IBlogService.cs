﻿using Miles.Service.Dtos.Blogs;
using Miles.Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Services.Interfaces
{
    public interface IBlogService
    {
        public Task<ApiResponse> CreateAsync(BlogPostDto dto);
        public Task<ApiResponse> GetAsync(int id);
        public Task<ApiResponse> GetAllAsync(int count,int page);
        public Task<ApiResponse> UpdateAsync(int id, BlogUpdateDto dto);
        public Task<ApiResponse> RemoveAsync(int id);
    }
}
