using FluentValidation;
using Miles.Service.Dtos.Features;
using Miles.Service.Dtos.Messages;
using Miles.Service.Dtos.UserPricings;
using Miles.Service.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Miles.Service.Validations.UserPricings
{
    public class UserPricingUpdateDtoValidation:AbstractValidator<UserPricingUpdateDto>
    {
        public UserPricingUpdateDtoValidation()
        {
			RuleFor(x => x.Name)
				  .NotEmpty()
				  .NotNull().WithMessage("Name can not be null")
				  .MinimumLength(3)
				  .MaximumLength(20);
			RuleFor(x => x.Price).
				NotNull();
		}
    }
}

