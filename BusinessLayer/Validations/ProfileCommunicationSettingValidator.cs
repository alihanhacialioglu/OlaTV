using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class ProfileCommunicationSettingValidator:AbstractValidator<ProfileCommunicationSetting>
    {
        public ProfileCommunicationSettingValidator()
        {
            RuleFor(m => m.ProfileCommunicationSettingSelection).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.ProfileId).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.CommunicationSettingId).NotEmpty().WithMessage("this field cannot be left blank");
        }
    }
}
