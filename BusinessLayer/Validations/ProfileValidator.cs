using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class ProfileValidator : AbstractValidator<Profile>
    {
        public ProfileValidator()
        {
            RuleFor(m => m.ProfileName).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.ProfileName).MaximumLength(20).WithMessage("Profile name must be no more than 20 characters");
            
            RuleFor(m => m.UserId).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.LanguageId).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.MaturityRatingId).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.TextColorId).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.TextSizeId).NotEmpty().WithMessage("this field cannot be left blank");
        }
    }
}
