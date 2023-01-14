using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class CreditCardValidator:AbstractValidator<CreditCard>
    {
        public CreditCardValidator()
        {
            RuleFor(m => m.CreditCardHolder).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.CreditCardNo).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.ExpirationDate).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.Cvv).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.UserId).NotEmpty().WithMessage("this field cannot be left blank");
        }
    }
}
