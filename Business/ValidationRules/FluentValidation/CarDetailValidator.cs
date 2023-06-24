using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarDetailValidator : AbstractValidator<CarDetailDto>
    {
        public CarDetailValidator()
        {
            RuleFor(x => x.CarName).NotEmpty();
            RuleFor(x => x.BrandName).NotEmpty();
            RuleFor(x => x.ColorName).NotEmpty();
            RuleFor(x => x.CarName).MinimumLength(2);
            RuleFor(x => x.CarName).MaximumLength(10);
            RuleFor(x => x.BrandName).MinimumLength(2);
            RuleFor(x => x.BrandName).MaximumLength(10);
            RuleFor(x => x.ColorName).MinimumLength(2);
            RuleFor(x => x.ColorName).MaximumLength(10);
        }
    }
}
