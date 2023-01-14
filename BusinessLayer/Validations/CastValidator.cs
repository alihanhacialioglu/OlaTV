using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class CastValidator:AbstractValidator<Cast>
    {
        public CastValidator()
        {
            RuleFor(m=>m.CastNameSurname).NotEmpty().WithMessage("this field cannot be left blank");
        }
    }
}
