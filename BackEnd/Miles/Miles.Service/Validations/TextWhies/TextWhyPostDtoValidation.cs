using FluentValidation;
using Miles.Service.Dtos.Messages;
using Miles.Service.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Miles.Service.Dtos.TextWhies;
using static System.Net.Mime.MediaTypeNames;

namespace Miles.Service.Validations.Messages
{
    public class TextWhyPostDtoValidation:AbstractValidator<TextWhyPostDto>
    {
        public TextWhyPostDtoValidation()
        {
            RuleFor(x => x.Title)
               .NotEmpty()
               .NotNull().WithMessage("Title can not be null")
               .MinimumLength(3)
               .MaximumLength(20);
            RuleFor(x => x.Text)
            .NotEmpty()
            .NotNull().WithMessage("Text can not be null")
            .MinimumLength(10)
            .MaximumLength(100);
            RuleFor(x => x.Text)
           .NotEmpty()
           .NotNull();
            RuleFor(x => x.SettingId).
                NotNull();
        }
    }
}

