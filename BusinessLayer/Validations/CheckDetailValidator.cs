using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class CheckDetailValidator:AbstractValidator<CheckDetail>
    {
        public CheckDetailValidator()
        {
            RuleFor(m => m.TotalPrice).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.CheckExplanation).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.CheckDate).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.ServiceDate).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.CreditCardId).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.IsDelete).NotEmpty().WithMessage("this field cannot be left blank");
         
          
        }
    }
}
