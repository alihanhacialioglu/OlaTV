using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class AdminValidator:AbstractValidator<Admin>
    {
        public AdminValidator()
        {
            RuleFor(m => m.AdminName).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.AdminPassword).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.EmailAddress).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.AdminType).NotEmpty().WithMessage("this field cannot be left blank");
        }
    }
}
