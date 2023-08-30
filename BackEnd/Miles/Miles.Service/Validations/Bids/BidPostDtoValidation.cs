using FluentValidation;
using Miles.Service.Dtos.Bids;
using Miles.Service.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Miles.Service.Validations.Bids
{
    public class BidPostDtoValidation:AbstractValidator<BidPostDto>
    {
        public BidPostDtoValidation()
        {
            RuleFor(x => x.CarId)
               .NotEmpty()
               .NotNull();
            RuleFor(x => x.AppUserId)
             .NotEmpty()
             .NotNull();
            RuleFor(x => x.Count)
               .NotEmpty()
               .NotNull();

        }
    }
}

