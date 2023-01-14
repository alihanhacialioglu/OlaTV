using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class TextColorValidator:AbstractValidator<TextColor>
    {
        public TextColorValidator() 
        {
          RuleFor(m=>m.TextColorName).NotEmpty().WithMessage("this field cannot be left blank");
        }

    }
}
