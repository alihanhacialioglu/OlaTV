using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
	public class GenreContentValidator : AbstractValidator<GenreContent>
	{
		public GenreContentValidator()
		{
			RuleFor(m => m.GenreId).NotEmpty().WithMessage("this field cannot be left blank");
			RuleFor(m => m.ContentId).NotEmpty().WithMessage("this field cannot be left blank");
		}
	}
}
