using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
	public class ContentCastTitleValidator : AbstractValidator<ContentCastTitle>
	{
		public ContentCastTitleValidator()
		{
			RuleFor(m=>m.ContentId).NotEmpty();
			RuleFor(m=>m.CastTitleId).NotEmpty();
		}
	}
}
