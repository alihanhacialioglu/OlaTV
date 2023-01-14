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
			RuleFor(m => m.StatusName).NotEmpty().WithMessage("this field cannot be left blank");
			RuleFor(m => m.MaturityExplanation).NotEmpty().WithMessage("this field cannot be left blank");
		}
	}
}
