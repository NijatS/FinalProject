using FluentValidation;
using Miles.Service.Dtos.Categories;
using Miles.Service.Dtos.Statuses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Validations.Statuses
{
    public class StatusUpdateDtoValidation:AbstractValidator<StatusUpdateDto>
    {
        public StatusUpdateDtoValidation()
        {
            RuleFor(x => x.Name)
               .NotEmpty()
               .NotNull().WithMessage("Name can not be null")
               .MinimumLength(2)
               .MaximumLength(40);
        }
    }
}
