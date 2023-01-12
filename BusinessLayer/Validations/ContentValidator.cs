using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
	public class ContentValidator : AbstractValidator<Content>
	{
		public ContentValidator()
		{
			RuleFor(m => m.ContentName).NotEmpty();
			RuleFor(m => m.ContentName).MaximumLength(25);

			RuleFor(m => m.MaturityRatingId).NotEmpty();
		}
	}
}
