using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
	public class ProfileVideoRatingValidator : AbstractValidator<ProfileVideoRating>
	{
		public ProfileVideoRatingValidator()
		{
			RuleFor(m => m.ProfileVideoRate).NotEmpty().WithMessage("Rate cannot be empty");
			RuleFor(m => m.ProfileId).NotEmpty().WithMessage("Profile cannot be empty");
			RuleFor(m => m.VideoId).NotEmpty().WithMessage("Video cannot be empty");
		}
	}
}
