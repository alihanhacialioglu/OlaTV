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
			RuleFor(m => m.Genre).NotEmpty();
			RuleFor(m => m.Content).NotEmpty();
		}
	}
}
