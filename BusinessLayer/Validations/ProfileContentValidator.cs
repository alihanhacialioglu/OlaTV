using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class ProfileContentValidator:AbstractValidator<ProfileContent>
    {
        public ProfileContentValidator()
        {

            RuleFor(m => m.ContentId).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.ProfileId).NotEmpty().WithMessage("this field cannot be left blank");
        }
    }
}
