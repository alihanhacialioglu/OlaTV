using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class CommunicationSettingValidator:AbstractValidator<CommunicationSetting>
    {
        public CommunicationSettingValidator()
        {
            RuleFor(m=>m.CommunicationSettingName).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m=>m.CommunicationSettingExplanation).NotEmpty().WithMessage("this field cannot be left blank");
        }
    }
}
