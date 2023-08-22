using FluentValidation;
using Miles.Service.Dtos.Categories;
using Miles.Service.Dtos.Bans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Validations.Bans
{
    public class BanPostDtoValidation:AbstractValidator<BanPostDto>
    {
        public BanPostDtoValidation()
        {
            RuleFor(x => x.Name)
               .NotEmpty()
               .NotNull().WithMessage("Name can not be null")
               .MinimumLength(2)
               .MaximumLength(40);
        }
    }
}
