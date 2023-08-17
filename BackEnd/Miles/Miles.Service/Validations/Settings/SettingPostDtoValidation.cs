using FluentValidation;
using Miles.Service.Dtos.Settings;
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
    public class SettingPostDtoValidation:AbstractValidator<SettingPostDto>
    {
        public SettingPostDtoValidation()
        {
            RuleFor(x => x.Address)
               .NotEmpty()
               .NotNull().WithMessage("Address can not be null")
               .MinimumLength(3)
               .MaximumLength(40);
            RuleFor(x => x)
              .Custom((x, context) =>
               {
                   if(x.Phone1 != null)
                   {
					   Regex re = new Regex("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$");
                       if(!re.IsMatch(x.Phone1))
                       {
						   context.AddFailure("phone1", "Phone format must be correct");
					   }
				   }
			   }
              );
            RuleFor(x => x)
             .Custom((x, context) =>
             {
                 if (x.Phone2 != null)
                 {
                     Regex re = new Regex("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$");
                     if (!re.IsMatch(x.Phone2))
                     {
                         context.AddFailure("phone1", "Phone format must be correct");
                     }
                 }
             }
             );
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
			   if (x.Logo != null)
			   {
				   if (!Helper.isImage(x.Logo))
				   {
					   context.AddFailure("logo", "The type of file must be image");
				   }
				   if (!Helper.isSizeOk(x.Logo, 2))
				   {
					   context.AddFailure("logo", "The size of image less than 2 mb");
				   }
			   }
		   });
			RuleFor(x => x)
		   .Custom((x, context) =>
		   {
			   if (x.PhotoWhy != null)
			   {
				   if (!Helper.isImage(x.PhotoWhy))
				   {
					   context.AddFailure("why", "The type of file must be image");
				   }
				   if (!Helper.isSizeOk(x.PhotoWhy, 2))
				   {
					   context.AddFailure("why", "The size of image less than 2 mb");
				   }
			   }
		   });
		}
    }
}

