using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
	public class VideoLanguageValidator : AbstractValidator<VideoLanguage>
	{
		public VideoLanguageValidator()
		{
			RuleFor(m => m.VideoId).NotEmpty().WithMessage("Video cannot be empty");
			RuleFor(m => m.LanguageId).NotEmpty().WithMessage("Subtitle Language cannot be empty");
		}
	}
}
