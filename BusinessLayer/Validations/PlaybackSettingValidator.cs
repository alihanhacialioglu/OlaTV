using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class PlaybackSettingValidator : AbstractValidator<PlaybackSetting>
    {
        public PlaybackSettingValidator()
        {
            RuleFor(m=>m.PlaybackSettingName).NotEmpty().WithMessage("This field cannot be left blank");
            RuleFor(m=>m.PlaybackSettingExplanation).NotEmpty().WithMessage("This field cannot be left blank");
        }
    }
}
