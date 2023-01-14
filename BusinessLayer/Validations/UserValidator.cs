using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(m => m.UserName).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.Password).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.EmailAddress).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.PhoneNumber).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.DateOfRegistration).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.AccessPin).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.PacketId).NotEmpty().WithMessage("this field cannot be left blank");

        }
    }
}
