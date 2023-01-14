using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class TextSizeValidator:AbstractValidator<TextSize>
    {
        public TextSizeValidator()
        {
            RuleFor(m=>m.TextSizeName).NotEmpty().WithMessage("this field cannot be left blank"); 
        }
    }
}
