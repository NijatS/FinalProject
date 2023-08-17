using FluentValidation;
using Miles.Service.Dtos.Categories;
using Miles.Service.Dtos.Positions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Validations.Positions
{
    public class PositionPostDtoValidation:AbstractValidator<PositionPostDto>
    {
        public PositionPostDtoValidation()
        {
            RuleFor(x => x.Name)
               .NotEmpty()
               .NotNull().WithMessage("Name can not be null")
               .MinimumLength(3)
               .MaximumLength(30);
        }
    }
}
