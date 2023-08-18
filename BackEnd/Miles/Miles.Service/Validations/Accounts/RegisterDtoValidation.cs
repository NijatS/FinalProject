using FluentValidation;
using Miles.Service.Dtos.Accounts;
using Miles.Service.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Miles.Service.Validations.Accounts
{
    public class RegisterDtoValidation:AbstractValidator<RegisterDto>
    {
        public RegisterDtoValidation() {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.Surname)
              .NotEmpty()
              .NotNull();
            RuleFor(x => x)
              .Custom((x, context) =>
              {
                  if (x.Email != null)
                  {
                      Regex re = new Regex("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$");
                      if (!re.IsMatch(x.Email))
                      {
                          context.AddFailure("email", "Email format must be correct");
                      }
                  }
              }
              );
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
