using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class CastTitleValidator : AbstractValidator<CastTitle>
    {
        public CastTitleValidator()
        {
            RuleFor(m=>m.CastId).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m=>m.TitleId).NotEmpty().WithMessage("this field cannot be left blank");
        }
    }
}
