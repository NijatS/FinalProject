using Miles.Core.Entities;
using Miles.Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Services.Interfaces
{
    public interface IBookService
    {
        public Task<ApiResponse> CreateAsync(Book book);
        public Task<ApiResponse> GetAsync(int id);
        public Task<ApiResponse> GetAllAsync(int count,int page, Expression<Func<Book, bool>>? expression);
        public Task<ApiResponse> UpdateAsync(int id, Book book);
        public Task<ApiResponse> RemoveAsync(int id);
    }
}
