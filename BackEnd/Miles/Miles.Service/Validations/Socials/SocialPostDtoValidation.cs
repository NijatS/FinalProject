using FluentValidation;
using Miles.Service.Dtos.Socials;
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
    public class SocialPostDtoValidation:AbstractValidator<SocialPostDto>
    {
        public SocialPostDtoValidation()
        {
            RuleFor(x => x.Icon)
               .NotEmpty()
               .NotNull();
			RuleFor(x => x.Link)
	           .NotEmpty()
	           .NotNull();
		}
    }
}

