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
            RuleFor(m => m.UserName).NotEmpty();
            RuleFor(m => m.Password).NotEmpty();
            RuleFor(m => m.EmailAddress).NotEmpty();
            RuleFor(m => m.PhoneNumber).NotEmpty();
            RuleFor(m => m.DateOfRegistration).NotEmpty();
            RuleFor(m => m.AccessPin).NotEmpty();
            RuleFor(m => m.PacketId).NotEmpty();

        }
    }
}
