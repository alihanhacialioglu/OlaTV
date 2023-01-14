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
            RuleFor(m => m.ProfileName).NotEmpty().WithMessage("Profile Name cannot be empty");
            RuleFor(m => m.ProfileName).MaximumLength(20).WithMessage("Profile name must be no more than 20 characters");
            RuleFor(m => m.ProfilePin).NotEmpty().WithMessage("Profile Pin cannot be empty");
            RuleFor(m => m.UserId).NotEmpty().WithMessage("User cannot be empty");
            RuleFor(m => m.LanguageId).NotEmpty().WithMessage("Language cannot be empty");
            RuleFor(m => m.MaturityRatingId).NotEmpty().WithMessage("Maturity Rating cannot be empty");
            RuleFor(m => m.TextColorId).NotEmpty().WithMessage("Text Color cannot be empty");
            RuleFor(m => m.TextSizeId).NotEmpty().WithMessage("Text Size cannot be empty");
        }
    }
}
