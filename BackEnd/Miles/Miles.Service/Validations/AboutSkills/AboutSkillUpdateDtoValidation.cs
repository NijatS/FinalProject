using FluentValidation;
using Miles.Service.Dtos.AboutSkills;
using Miles.Service.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Validations.Categories
{
    public class AboutSkillUpdateDtoValidation:AbstractValidator<AboutSkillUpdateDto>
    {
        public AboutSkillUpdateDtoValidation()
        {
			RuleFor(x => x.Name)
			 .NotEmpty()
			 .NotNull().WithMessage("Name can not be null");
            RuleFor(x => x)
           .Custom((x, context) =>
           {
               if (x.Degree != null)
               {
                   if (x.Degree > 100 || x.Degree < 0)
                   {
                       context.AddFailure("degree", "Degree value must between 0 and 100");
                   }
               }
           }
           );
        }
    }
}
