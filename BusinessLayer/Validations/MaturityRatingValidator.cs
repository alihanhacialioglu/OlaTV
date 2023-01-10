using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
	public class MaturityRatingValidator : AbstractValidator<MaturityRating>
	{
		public MaturityRatingValidator()
		{
			RuleFor(m => m.StatusName).NotEmpty();
			RuleFor(m => m.MaturityExplanation).NotEmpty();
		}
	}
}
