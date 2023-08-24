﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Miles.Core.Entities;
using Miles.Service.Services.Implementations;
using Miles.Service.Services.Interfaces;
using System;
using System.Composition;
using System.Linq.Expressions;

namespace Miles.App.Controllers
{
    public class ShopController : Controller
    {
        private readonly ICarService _carService;
		private readonly IBrandService _brandService;
		private readonly IColorService _colorService;
		private readonly IFuelService _fuelService;
		private readonly IBanService _banService;

		public ShopController(ICarService carService, IBrandService brandService, IColorService colorService, IFuelService fuelService, IBanService banService)
		{
			_carService = carService;
			_brandService = brandService;
			_colorService = colorService;
			_fuelService = fuelService;
			_banService = banService;
		}
		public async Task<IActionResult> Index(string? brand,string? model,double? minprice,double? maxprice,int? minyear,int? maxyear,int? color,int? ban,int? fuel, int page = 1)
        {
            var resultCar = await _carService.GetAllAsync(0, 0,null);
            IEnumerable<Car> Cars = (IEnumerable<Car>)resultCar.items;
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
            if (model is not null )
            {
                Expression<Func<Car, bool>> expression1 = (x => x.Model.Name == model);
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
            resultCar = await _carService.GetAllAsync(0, 0,expression);
            Cars = (IEnumerable<Car>)resultCar.items;
            TotalCount = Cars.Count();
            return View(Cars);
        }
        public async Task<IActionResult> Detail()
        {
            return View();
        }
		public async Task<IActionResult> Filter()
		{
			return View();
		}
        public Expression<Func<Car, bool>> CombineFilters(Expression<Func<Car, bool>> filter1, Expression<Func<Car, bool>> filter2)
        {
            // Create parameter expression
            ParameterExpression parameter = Expression.Parameter(typeof(Car), "car");

            // Invoke the filter expressions with the parameter
            var invokedFilter1 = Expression.Invoke(filter1, parameter);
            var invokedFilter2 = Expression.Invoke(filter2, parameter);

            // Combine the expressions using AndAlso
            Expression combinedExpr = Expression.AndAlso(invokedFilter1, invokedFilter2);

            // Create and return the combined lambda expression
            return Expression.Lambda<Func<Car, bool>>(combinedExpr, parameter);
        }
    }
}
