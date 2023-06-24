﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.Description).MinimumLength(2);
            RuleFor(c => c.Description).MaximumLength(10);
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(200000).When(c => c.BrandId == 1);
            RuleFor(c => c.Description).Must(StartWithA).WithMessage("Araba ismi A harfi başlamalıdır");

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
