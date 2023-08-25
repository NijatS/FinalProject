using FluentValidation;
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
    public class MessagePostDtoValidation:AbstractValidator<MessagePostDto>
    {
        public MessagePostDtoValidation()
        {
            RuleFor(x => x.FirstName)
               .NotEmpty()
               .NotNull().WithMessage("Name can not be null")
               .MinimumLength(3)
               .MaximumLength(20);
            RuleFor(x => x.Address)
            .MaximumLength(100);
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
            RuleFor(x => x.Phone)
       .NotEmpty()
       .NotNull().WithMessage("PhoneNumber can not be null");
            /* RuleFor(x => x)
             .Custom((x, context) =>
             {
                 Regex reg = new Regex(@"^(\\+\\d{1,2}\\s?)?1?\\-?\\.?\\s?\\(?\\d{3}\\)?[\\s.-]?\\d{3}[\\s.-]?\\d{4}$");
                 if (!reg.IsMatch(x.Phone))
                 {
                         context.AddFailure("phone", "Format must be phone");
                 }
             });

             RuleFor(x => x)
		  .Custom((x, context) =>
		  {
              if (x.Email != null)
              {
                  Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                  if (!reg.IsMatch(x.Email))
                  {
                      context.AddFailure("email", "Format must be email");
                  }
              }
		  });
            */

        }
    }
}

