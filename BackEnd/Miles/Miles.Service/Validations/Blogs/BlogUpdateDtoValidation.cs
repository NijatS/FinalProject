using FluentValidation;
using Miles.Service.Dtos.Blogs;
using Miles.Service.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Validations.Categories
{
    public class BlogUpdateDtoValidation:AbstractValidator<BlogUpdateDto>
    {
        public BlogUpdateDtoValidation()
        {
            RuleFor(x => x.Title)
                     .NotEmpty()
                     .NotNull().WithMessage("Name can not be null")
                     .MinimumLength(3)
                     .MaximumLength(30);
            RuleFor(x => x.Description)
            .NotEmpty()
            .NotNull().WithMessage("Description can not be null")
            .MinimumLength(30);
            RuleFor(x => x.Author)
           .NotEmpty()
            .NotNull().WithMessage("Author Name can not be null")
            .MinimumLength(3)
            .MaximumLength(30);
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
            RuleFor(x => x)
            .Custom((x, context) =>
            {
                if (x.fileAuthor != null)
                {
                    if (!Helper.isImage(x.fileAuthor))
                    {
                        context.AddFailure("file", "The type of file must be image");
                    }
                    if (!Helper.isSizeOk(x.fileAuthor, 2))
                    {
                        context.AddFailure("file", "The size of image less than 2 mb");
                    }
                }
            });

        }
    }
}
