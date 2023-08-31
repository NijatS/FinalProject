using AutoMapper;
using Miles.Core.Entities;
using Miles.Core.Repositories;
using Miles.Data.Repositories;
using Miles.Service.Dtos.Categories;
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
    public class AuctionService : IAuctionService
    {
        private readonly IAuctionRepository _repository;
        private readonly IMapper _mapper;

        public AuctionService(IAuctionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ApiResponse> CreateAsync(Auction dto)
        {
            Auction Auction = _mapper.Map<Auction>(dto);
            Auction.AuctionStart = DateTime.UtcNow.AddHours(4);
            Auction.AuctionEnd = DateTime.UtcNow.AddHours(4).AddSeconds(10);
            await _repository.AddAsync(Auction);
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 201,
                items = Auction
            };
        }

        public async Task<ApiResponse> GetAllAsync(int count,int page, Expression<Func<Auction, bool>>? expression)
        {
            IEnumerable<Auction> Auctions = await _repository.GetAllAsync(x => !x.IsDeleted,count,page);
            if(expression != null)
            {
                Auctions = await _repository.GetAllAsync(expression, count, page);
            }
            return new ApiResponse
            {
                items = Auctions,
                StatusCode = 200
            };
        }

        public async Task<ApiResponse> GetAsync(int id)
        {
               Auction Auction = await _repository.GetAsync(x => !x.IsDeleted && x.Id == id);

            if (Auction is null)
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
                items = Auction
            };
        }

        public async Task<ApiResponse> RemoveAsync(int id)
        {
            Auction Auction = await _repository.GetAsync(x => x.Id == id);
            if (Auction is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Auction.IsDeleted = true;
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Auction
            };
        }

        public async Task<ApiResponse> UpdateAsync(int id, Auction dto)
        {
           
            Auction Auction = await _repository.GetAsync(x => x.Id == id && !x.IsDeleted);
            if (Auction is null)
            {
                return new ApiResponse
                {
                    StatusCode = 404,
                    Description = "Not found"
                };
            }
            Auction.UpdatedAt = DateTime.UtcNow.AddHours(4);
            Auction.AuctionStart = DateTime.UtcNow.AddHours(4);
            Auction.AuctionEnd = DateTime.UtcNow.AddHours(4).AddSeconds(11);
            await _repository.SaveAsync();
            return new ApiResponse
            {
                StatusCode = 200,
                items = Auction
            };
        }
    }
}
