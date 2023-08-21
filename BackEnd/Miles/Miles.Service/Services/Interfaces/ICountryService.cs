﻿using Miles.Service.Dtos.Countries;
using Miles.Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Services.Interfaces
{
    public interface ICountryService
    {
        public Task<ApiResponse> CreateAsync(CountryPostDto dto);
        public Task<ApiResponse> GetAsync(int id);
        public Task<ApiResponse> GetAllAsync(int count, int page);
        public Task<ApiResponse> UpdateAsync(int id, CountryUpdateDto dto);
        public Task<ApiResponse> RemoveAsync(int id);
    }
}
