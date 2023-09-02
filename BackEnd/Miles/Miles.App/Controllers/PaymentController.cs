using Braintree;
using Microsoft.AspNetCore.Mvc;
using Miles.Core.Entities;
using Miles.Service.Dtos.Cars;
using Miles.Service.Services.Interfaces;
using Miles.Service.ViewModels;

namespace Miles.App.Controllers
{
    public class PaymentController : Controller
    {
        private readonly IBraintreeService _braintreeService;
        private readonly IBookService _bookService;
        private readonly ICarService _carService;


        public PaymentController(IBraintreeService braintreeService, IBookService bookService, ICarService carService)
        {
            _braintreeService = braintreeService;
            _bookService = bookService;
            _carService = carService;
        }
        public async Task<IActionResult> Success()
        {
            return View();
        }

        public async Task<IActionResult> Payment(double amount,int carId,string userId)
        {
            int i = 0;
            var gateway = _braintreeService.GetGateway();
            var clientToken = gateway.ClientToken.Generate();
            ViewBag.ClientToken = clientToken;
            Book book = new Book
            {
                CarId = carId,
                AppUserId= userId,
                Description= "Hellow man",
                CreatedAt = DateTime.UtcNow,
                Price= amount,
                Title = "This is title",
            };
            if (i == 0)
            {
                await _bookService.CreateAsync(book);
                i++;
            }

            var result = await _bookService.GetAllAsync(0, 0, x => x.CarId == carId);
            int BookId = ((IEnumerable<Book>)result.items).FirstOrDefault().Id;
            var data = new BookPurchaseVM
            {
                Id = BookId,
                AppUserId =userId,
                CarId = carId,
                Description = "Hellow man",
                Title = "This is title",
                Price = amount,
                Nonce = ""
            };
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Create(BookPurchaseVM model,double amount,int carId)
        {
            var results = await _carService.GetAsync(model.CarId);
            CarUpdateDto dto = (CarUpdateDto)results.items;
            var gateway = _braintreeService.GetGateway();
            var request = new TransactionRequest
            {
                Amount = Convert.ToDecimal(amount),
                PaymentMethodNonce = model.Nonce,
                Options = new TransactionOptionsRequest
                {
                    SubmitForSettlement = true
                },
                CustomerId = model.AppUserId
            };

            Result<Transaction> result = gateway.Transaction.Sale(request);

            if (result.IsSuccess())
            {
                dto.StatusId = 3;
                await _carService.UpdateAsync(carId, dto);
                return RedirectToAction("Success", "Payment");
            }
            else
            {
                return NotFound();
            }
        }
    }
}
