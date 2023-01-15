using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
	public class ProfilePlaybackSettingValidator : AbstractValidator<ProfilePlaybackSetting>
	{
		public ProfilePlaybackSettingValidator()
		{
			RuleFor(m => m.PlaybackSettingId).NotEmpty().WithMessage("This field cannot be left blank");
			RuleFor(m => m.ProfileId).NotEmpty().WithMessage("This field cannot be left blank");
		}
	}
}
