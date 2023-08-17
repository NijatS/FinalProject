using FluentValidation;
using Miles.Service.Dtos.Staffs;
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
    public class StaffUpdateDtoValidation:AbstractValidator<StaffUpdateDto>
    {
        public StaffUpdateDtoValidation()
        {
            RuleFor(x => x.FullName)
               .NotEmpty()
               .NotNull().WithMessage("Name can not be null")
               .MinimumLength(3)
               .MaximumLength(30);
            RuleFor(x => x.Info)
                  .NotEmpty()
                   .NotNull()
                   .MinimumLength(3)
                    .MaximumLength(50);
            RuleFor(x => x.PositionId)
                   .NotEmpty()
                   .NotNull();
            RuleFor(x => x)
           .Custom((x, context) =>
           {
               if (x.file != null)
               {
                   if (!Helper.isImage(x.file))
                   {
                       context.AddFailure("file", "The type of file must be image");
                   }
                   if (!Helper.isSizeOk(x.file, 2))
                   {
                       context.AddFailure("file", "The size of image less than 2 mb");
                   }
               }
           });

        }
    }
}

