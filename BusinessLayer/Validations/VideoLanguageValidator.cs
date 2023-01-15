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
			RuleFor(m => m.VideoId).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.LanguageId).NotEmpty().WithMessage("this field cannot be left blank");
        }
	}
}
