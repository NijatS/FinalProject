using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Miles.Core.Entities;
using Miles.Core.Repositories;
using Miles.Service.Dtos.Bids;
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
    public class BidService : IBidService
    {
        private readonly IBidRepository _repository;
        private readonly IMapper _mapper;

        public BidService(IBidRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ApiResponse> CreateAsync(BidPostDto dto)
        {
            Bid Bid = _mapper.Map<Bid>(dto);
            await _repository.AddAsync(Bid);
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 201,
                items = Bid
            };
        }

        public async Task<ApiResponse> GetAllAsync(int count,int page, Expression<Func<Bid, bool>>? expression)
        {
            IEnumerable<Bid> Bids = await _repository.GetAllAsync(x => !x.IsDeleted,count,page);
            if (expression != null)
            {
                Bids = await _repository.GetAllAsync(expression, count, page);
            }
            return new ApiResponse
            {
                items = Bids,
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(Expression<Func<Bid, bool>> expression)
        {
            IEnumerable<Bid> Bids = await _repository.GetAllAsync(expression, 0, 0).Result.Include(x=>x.AppUser).ThenInclude(y=>y.Country).ToListAsync();
            Bid Bid = Bids.OrderByDescending(x=>x.Count).FirstOrDefault();
         
            if (Bid is null)
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
                items = Bid
            };
        }

        public async Task<ApiResponse> RemoveAsync(int id)
        {
            Bid Bid = await _repository.GetAsync(x => x.Id == id);
            if (Bid is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Bid.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Bid
            };
        }
    }
}
