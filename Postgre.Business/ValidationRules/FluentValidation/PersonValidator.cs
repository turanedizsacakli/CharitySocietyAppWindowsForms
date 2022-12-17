using FluentValidation;
using Postgre.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.Business.ValidationRules.FluentValidation
{
    public class PersonValidator:AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Lütfen isim giriniz...");
            RuleFor(p => p.Surname).NotEmpty();
            RuleFor(p => p.LocalId).NotEmpty();
            //RuleFor(p => p.LocalId).GreaterThan(0);
            //RuleFor(p => p.LocalId).GreaterThan(0).When(p => p.CategorylId == 2);
            RuleFor(p => p.LocalId).Must(EqualEleven).WithMessage("TC Kimlik Numarası 11 Haneli Olmalı...");


        }

        private bool EqualEleven(string arg)
        {
            return arg.Count()==11;
        }
    }
}
