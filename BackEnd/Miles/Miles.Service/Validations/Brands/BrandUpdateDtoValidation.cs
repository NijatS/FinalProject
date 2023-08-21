using FluentValidation;
using Miles.Service.Dtos.Brands;
using Miles.Service.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Validations.Categories
{
    public class BrandUpdateDtoValidation:AbstractValidator<BrandUpdateDto>
    {
        public BrandUpdateDtoValidation()
        {
			RuleFor(x => x.Name)
			 .NotEmpty()
			 .NotNull().WithMessage("Name can not be null")
			 .MinimumLength(3)
			 .MaximumLength(40);
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
