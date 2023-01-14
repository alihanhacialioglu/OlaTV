using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class LanguageValidator:AbstractValidator<Language>
    {
        public LanguageValidator()
        {
            RuleFor(m=>m.LanguageName).NotEmpty().WithMessage("this field cannot be left blank");
        }
    }
}
