using FluentValidation;
using Miles.Service.Dtos.Models;
using Miles.Service.Dtos.Messages;
using Miles.Service.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Miles.Service.Validations.Messages
{
    public class ModelUpdateDtoValidation:AbstractValidator<ModelUpdateDto>
    {
        public ModelUpdateDtoValidation()
        {
            RuleFor(x => x.Name)
              .NotEmpty()
              .NotNull().WithMessage("Name can not be null")
              .MinimumLength(3)
              .MaximumLength(50);
            RuleFor(x => x.BrandId).
                NotNull();
        }
    }
}

