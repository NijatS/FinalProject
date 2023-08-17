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
    public class SettingUpdateDtoValidation:AbstractValidator<SettingUpdateDto>
    {
        public SettingUpdateDtoValidation()
        {
			RuleFor(x => x.Address)
						   .NotEmpty()
						   .NotNull().WithMessage("Address can not be null")
						   .MinimumLength(3)
						   .MaximumLength(40);
			RuleFor(x => x)
			  .Custom((x, context) =>
			  {
				  if (x.Phone1 != null)
				  {
					  Regex re = new Regex("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$");
					  if (!re.IsMatch(x.Phone1))
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
            RuleFor(x => x.Email).
			 NotNull();
			RuleFor(x => x)
		   .Custom((x, context) =>
		   {
			   if (x.fileLogo != null)
			   {
				   if (!Helper.isImage(x.fileLogo))
				   {
					   context.AddFailure("logo", "The type of file must be image");
				   }
				   if (!Helper.isSizeOk(x.fileLogo, 2))
				   {
					   context.AddFailure("logo", "The size of image less than 2 mb");
				   }
			   }
		   });
			RuleFor(x => x)
		   .Custom((x, context) =>
		   {
			   if (x.file != null)
			   {
				   if (!Helper.isImage(x.file))
				   {
					   context.AddFailure("why", "The type of file must be image");
				   }
				   if (!Helper.isSizeOk(x.file, 2))
				   {
					   context.AddFailure("why", "The size of image less than 2 mb");
				   }
			   }
		   });
		}
    }
}

