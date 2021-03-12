using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.ModelName).MinimumLength(2);
            RuleFor(c => c.ModelName).NotEmpty();
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(0);
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(400).When(c => c.BrandId == 10);
            //Kendi kuralını yazmak için alttaki kodla yeni method oluştur.
            //RuleFor(c => c.Name).Must(StartsWithA);
            // 

        }

        private bool StartsWithA(string arg)
        {
            throw new NotImplementedException();
        }
    }
}
