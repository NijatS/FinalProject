using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Miles.Core.Entities;
using Miles.Service.Dtos.Bids;
using Miles.Service.Dtos.Cars;
using Miles.Service.Dtos.Comments;
using Miles.Service.Dtos.Messages;
using Miles.Service.Services.Implementations;
using Miles.Service.Services.Interfaces;
using Miles.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace Miles.App.Controllers
{
    public class ShopController : Controller
    {
        private readonly ICarService _carService;
		private readonly IBrandService _brandService;
		private readonly IColorService _colorService;
		private readonly IFuelService _fuelService;
		private readonly IBanService _banService;
        private readonly IAccountService _accountService;
        private readonly ICommentService _commentService;
        private readonly IBidService _bidService;
        private readonly IAuctionService _auctionService;
        private readonly IEmailService _emailService;

        public ShopController(ICarService carService, IBrandService brandService, IColorService colorService, IFuelService fuelService, IBanService banService, IAccountService accountService, ICommentService commentService, IBidService bidService, IAuctionService auctionService, IEmailService emailService)
        {
            _carService = carService;
            _brandService = brandService;
            _colorService = colorService;
            _fuelService = fuelService;
            _banService = banService;
            _accountService = accountService;
            _commentService = commentService;
            _bidService = bidService;
            _auctionService = auctionService;
            _emailService = emailService;      
        }
        public async Task<IActionResult> Index(string? brand,int? sort,int? model,double? minprice,double? maxprice,int? minyear,int? maxyear,int? color,int? ban,int? fuel, int page = 1)
        {
            ViewBag.IsDataLoading = true;
            var resultCar = await _carService.GetAllAsync(0, 0, x => !x.IsDeleted && x.StatusId == 1 || x.StatusId == 2);
            IEnumerable<Car> Cars = (IEnumerable<Car>)resultCar.items;
            if (sort is not null && sort != 0)
            {
                if (sort == 1)
                {
                    Cars = Cars.OrderBy(x => x.Price);
                }
                else if (sort == 2)
                {
                    Cars = Cars.OrderByDescending(x => x.Price);
                }
                else if(sort == 3)
                {
                    Cars = Cars.OrderBy(x => x.FabricationYear);
                }
                else
                {
                    Cars = Cars.OrderBy(x => x.Model.Name);
                }
            }
            int TotalCount = Cars.Count();
            ViewBag.TotalPage = (int)Math.Ceiling((decimal)TotalCount / 6);
            ViewBag.CurrentPage = page;
			var resultFuel = await _fuelService.GetAllAsync(0, 0);
			var resultBan = await _banService.GetAllAsync(0, 0);
			var resultColor = await _colorService.GetAllAsync(0, 0);
			var resultBrand = await _brandService.GetAllAsync(0, 0);
			ViewBag.Fuels = resultFuel.items;
			ViewBag.Bans = resultBan.items;
			ViewBag.Colors = resultColor.items;
			ViewBag.Brands = resultBrand.items;
            Expression<Func<Car, bool>> expression = (x=>!x.IsDeleted && x.StatusId==1 || x.StatusId==2);
            
            if (brand is not null )
			{
                Expression<Func<Car, bool>> expression1 = (x => x.Model.Brand.Name == brand);
                expression = CombineFilters(expression, expression1);
            }
            if (model is not null && model !=0)
            {
                Expression<Func<Car, bool>> expression1 = (x => x.ModelId == model);
                expression = CombineFilters(expression, expression1);
            }
            if(minyear is not null)
            {
                Expression<Func<Car, bool>> expression1 = (x => x.FabricationYear >= minyear);
                expression = CombineFilters(expression, expression1);
            }
            if(maxyear is not null)
            {
                Expression<Func<Car, bool>> expression1 = (x => x.FabricationYear <= maxyear);
                expression = CombineFilters(expression, expression1);
            }
            if(minprice is not null)
            {
                Expression<Func<Car, bool>> expression1 = (x => x.Price >= minprice);
                expression = CombineFilters(expression, expression1);
            }
            if (maxprice is not null)
            {
                Expression<Func<Car, bool>> expression1 = (x => x.Price <= maxprice);
                expression = CombineFilters(expression, expression1);
            }
            if (color is not null)
            {
                Expression<Func<Car, bool>> expression1 = (x => x.ColorId == color);
                expression = CombineFilters(expression, expression1);
            }
            if (ban is not null)
            {
                Expression<Func<Car, bool>> expression1 = (x => x.BanId == ban);
                expression = CombineFilters(expression, expression1);
            }
            if (fuel is not null)
            {
                Expression<Func<Car, bool>> expression1 = (x => x.FuelId == fuel) ;
                expression = CombineFilters(expression, expression1);
            }
            if (sort is null || sort == 0)
            {
                resultCar = await _carService.GetAllAsync(0, 0, expression);
                Cars = (IEnumerable<Car>)resultCar.items;
            }
            TotalCount = Cars.Count();
            ViewBag.IsDataLoading = false;
            return View(Cars);
        }
        public async Task<IActionResult> Detail(int id)
        {
            ViewBag.IsDataLoading = true;
            var resultCar = await _carService.GetAsync(id);
            var resultCars = await _carService.GetAllAsync(0 ,0,x=> x.Id != id);
            var resultComment = await _commentService.GetAllAsync(0,0,x=>x.CarID == id && !x.IsDeleted);
            ShopVM shopVM = new ShopVM()
            {
                Car = (Car)resultCar.itemView,
                Cars = (IEnumerable<Car>)resultCars.items,
                Comments = (IEnumerable<Comment>)resultComment.items,
            };
            ViewBag.IsDataLoading = false;
            return View(shopVM);
        }
        private Expression<Func<Car, bool>> CombineFilters(Expression<Func<Car, bool>> filter1, Expression<Func<Car, bool>> filter2)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(Car), "car");
            var invokedFilter1 = Expression.Invoke(filter1, parameter);
            var invokedFilter2 = Expression.Invoke(filter2, parameter);
            Expression combinedExpr = Expression.AndAlso(invokedFilter1, invokedFilter2);
            return Expression.Lambda<Func<Car, bool>>(combinedExpr, parameter);
        }
        public async Task<IActionResult> PostComment(CommentPostDto dto)
        {
            var result = await _accountService.GetUser();
            AppUser appUser = (AppUser)result.items;
            dto.AppUserId = appUser.Id;
            dto.AppUser = appUser;
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }
            await _commentService.CreateAsync(dto);
            return Redirect(Request.Headers["Referer"].ToString());
        }
        public async Task<IActionResult> Search(string search)
        {
           var result = await _carService.GetAllAsync(0, 0, x => !x.IsDeleted && (x.Model.Name.Trim().ToLower() +" " + x.Model.Brand.Name.Trim().ToLower()).Contains(search.Trim().ToLower()) || (x.Model.Brand.Name.Trim().ToLower() + " " + x.Model.Name.Trim().ToLower()).Contains(search.Trim().ToLower()));
           IEnumerable<Car> Cars = (IEnumerable<Car>)result.items;
           return Json(Cars);
        }
        public async Task<IActionResult> PostBid(BidPostDto dto)
        {
            var result = await _bidService.CreateAsync(dto);
            return Json("Ok");
        }
        public async Task<IActionResult> PostAuction(bool status,int CarId)
        {
            Auction auction = new Auction { 
                CarId = CarId
            };

            if (status)
            {
                var result = await _auctionService.CreateAsync(auction);
            }
            else
            {
                var result = await _auctionService.GetAllAsync(0,0,x=>x.CarId== auction.CarId);
                int id = ((IEnumerable<Auction>)result.items).FirstOrDefault().Id;
                result = await _auctionService.UpdateAsync(id,auction);
            }
            return Json("Ok");
        }
        public async Task<IActionResult> GetAuction(int carId)
        {
            var result = await _auctionService.GetAllAsync(0, 0, x => x.CarId == carId && !x.IsDeleted);
            Auction auction = ((IEnumerable<Auction>)result.items).FirstOrDefault();
            return Json(auction);
        }
        public async Task<IActionResult> GetHighBid(int carId)
        {
            var result = await _bidService.GetAsync(x => !x.IsDeleted && x.CarId ==carId);
            return Json(result.items);
        }
        public async Task<IActionResult> SellCar(int carId)
        {
            var result =await _carService.GetAsync(carId);
            CarUpdateDto dto = (CarUpdateDto)result.items;
            result = await _bidService.GetAsync(x => !x.IsDeleted && x.CarId ==carId);
            Bid bid = (Bid)result.items;
            dto.AuctionWinPrice = bid.Count;
            dto.WinDate = DateTime.Now;
            dto.StatusId = 4;
            dto.WinnerId = bid.AppUserId;
            result = await _carService.UpdateAsync(carId, dto);
            if (result.StatusCode == 200)
            {
                 result = await _accountService.GetUserById(dto.WinnerId);
                AppUser winner =(AppUser)result.items;
                await _emailService.SendMail("nicatsoltanli03@gmail.com", winner.Email,
                    "Auction Winner", "Congratulation.You Win " +dto.Vin +" Car.Please wait owner Report.", null, winner.Name + " " + winner.Surname);
                result = await _accountService.GetUserById(dto.AppUserId);
                AppUser owner = (AppUser)result.items;
                await _emailService.SendMail("nicatsoltanli03@gmail.com", owner.Email,
                    "About Auction", "Your " + dto.Vin + " Car auction ended.Please look at results", null, owner.Name + " " + owner.Surname);
            }
            return Json("Ok");
        }
      
    }
}
