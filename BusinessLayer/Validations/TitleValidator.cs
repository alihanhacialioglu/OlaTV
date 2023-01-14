using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class TitleValidator:AbstractValidator<Title>
    {
        public TitleValidator()
        {
            RuleFor(m=>m.TitleName).NotEmpty().WithMessage("this field cannot be left blank");
        }
    }
}
