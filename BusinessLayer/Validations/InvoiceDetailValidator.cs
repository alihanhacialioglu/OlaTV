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
    public class InvoiceDetailValidator:AbstractValidator<InvoiceDetail>
    {
        public InvoiceDetailValidator()
        {
            RuleFor(m => m.TotalPrice).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.InvoiceExplanation).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.InvoiceDate).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.ServiceDate).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.CreditCardId).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.IsDelete).NotEmpty().WithMessage("this field cannot be left blank");
         
          
        }
    }
}
