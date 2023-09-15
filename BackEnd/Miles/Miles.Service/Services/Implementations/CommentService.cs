using AutoMapper;
using Braintree;
using Microsoft.EntityFrameworkCore;
using Miles.Core.Entities;
using Miles.Core.Repositories;
using Miles.Data.Context;
using Miles.Service.Dtos.Comments;
using Miles.Service.Responses;
using Miles.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Services.Implementations
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _repository;
        private readonly IMapper _mapper;
    

        public CommentService(ICommentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ApiResponse> CreateAsync(CommentPostDto dto)
        {
            Comment Comment = _mapper.Map<Comment>(dto);
            await _repository.AddAsync(Comment);
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 201,
                items = Comment
            };
        }
        public async Task<ApiResponse> GetAllAsync(int count,int page, Expression<Func<Comment, bool>>? expression)
        {
            IEnumerable<Comment> Comments = new List<Comment>();
            if (expression is null)
            {
                Comments = await _repository.GetAllAsync(x => !x.IsDeleted, count, page, "AppUser");
            }
            else
            {
                Comments = await _repository.GetAllAsync(expression, count, page, "AppUser");
            }
            return new ApiResponse
            {
                items = Comments,
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int id)
        {
            Comment Comment = await _repository.GetAsync(x => !x.IsDeleted && x.Id == id, "AppUser");
            if (Comment is null)
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
                items = Comment
            };
        }

        public async Task<ApiResponse> RemoveAsync(int id)
        {
            Comment Comment = await _repository.GetAsync(x => x.Id == id);
            if (Comment is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Comment.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Comment
            };
        }
    }
}
