using FluentValidation;
using Miles.Service.Dtos.Colors;
using Miles.Service.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Validations.Categories
{
    public class ColorUpdateDtoValidation:AbstractValidator<ColorUpdateDto>
    {
        public ColorUpdateDtoValidation()
        {
            RuleFor(x => x.Name)
               .NotEmpty()
               .NotNull().WithMessage("Name can not be null")
               .MinimumLength(3)
               .MaximumLength(30);
        }
    }
}
