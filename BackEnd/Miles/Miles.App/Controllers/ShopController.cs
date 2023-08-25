using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Miles.Core.Entities;
using Miles.Service.Dtos.Comments;
using Miles.Service.Dtos.Messages;
using Miles.Service.Services.Implementations;
using Miles.Service.Services.Interfaces;
using Miles.Service.ViewModels;
using System;
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

        public ShopController(ICarService carService, IBrandService brandService, IColorService colorService, IFuelService fuelService, IBanService banService, IAccountService accountService, ICommentService commentService)
        {
            _carService = carService;
            _brandService = brandService;
            _colorService = colorService;
            _fuelService = fuelService;
            _banService = banService;
            _accountService = accountService;
            _commentService = commentService;
        }
        public async Task<IActionResult> Index(string? brand,int? sort,int? model,double? minprice,double? maxprice,int? minyear,int? maxyear,int? color,int? ban,int? fuel, int page = 1)
        {
            var resultCar = await _carService.GetAllAsync(0, 0,null);
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
            Expression<Func<Car, bool>> expression = (x=>!x.IsDeleted);
            
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
            return View(Cars);
        }
        public async Task<IActionResult> Detail(int id)
        {
            var resultCar = await _carService.GetAsync(id);
            var resultCars = await _carService.GetAllAsync(0 ,0,x=> x.Id != id);
            var resultComment = await _commentService.GetAllAsync(0,0,x=>x.CarID == id && !x.IsDeleted);
            ShopVM shopVM = new ShopVM()
            {
                Car = (Car)resultCar.itemView,
                Cars = (IEnumerable<Car>)resultCars.items,
                Comments = (IEnumerable<Comment>)resultComment.items,
            };
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
    }
}
