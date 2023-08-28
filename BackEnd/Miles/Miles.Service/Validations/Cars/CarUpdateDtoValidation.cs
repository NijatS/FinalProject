using FluentValidation;
using Miles.Service.Dtos.Cars;
using Miles.Service.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles.Service.Validations.Categories
{
    public class CarUpdateDtoValidation:AbstractValidator<CarUpdateDto>
    {
        public CarUpdateDtoValidation()
        {
            RuleFor(x => x.Vin)
               .NotEmpty()
               .NotNull().WithMessage("Vin can not be null")
               .MinimumLength(14)
               .MaximumLength(17);
            RuleFor(x => x.Description)
            .NotEmpty()
            .NotNull().WithMessage("Description can not be null")
            .MinimumLength(30);
            RuleFor(x => x.ModelId)
           .NotEmpty();

            RuleFor(x => x)
             .Custom((x, context) =>
             {
                 if (x.FabricationYear <= 2000)
                 {
                     context.AddFailure("FabricationYear", "FabricationYear must bigger than 2000");
                 }
             });
            RuleFor(x => x.Odometer)
           .NotEmpty();
            RuleFor(x => x.FuelId)
           .NotEmpty()
           .NotNull();
            RuleFor(x => x.NoGears)
              .NotEmpty()
           .NotNull();
            RuleFor(x => x.Transmission)
         .NotEmpty()
           .NotNull();
            RuleFor(x => x.FuelCity)
        .NotEmpty()
           .NotNull();
            RuleFor(x => x.FuelWay)
    .NotEmpty()
           .NotNull();
            RuleFor(x => x.Motor)
        .NotEmpty()
           .NotNull();
            RuleFor(x => x.ColorId)
   .NotEmpty()
           .NotNull();
            RuleFor(x => x.Price)
   .NotEmpty()
           .NotNull();
            RuleFor(x => x.Description)
   .NotEmpty()
           .NotNull();
            RuleFor(x => x.BanId)
.NotEmpty()
        .NotNull();
            RuleFor(x => x)
            .Custom((x, context) =>
            {
                if (x.FormFiles is not null)
                {
                    foreach (var file in x.FormFiles)
                    {
                        if (file != null)
                        {
                            if (!Helper.isImage(file))
                            {
                                context.AddFailure("FormFiles", "The type of file must be image");
                            }
                            if (!Helper.isSizeOk(file, 2))
                            {
                                context.AddFailure("FormFiles", "The size of image less than 2 mb");
                            }
                        }
                    }
                }
            });
        }
    }
}
