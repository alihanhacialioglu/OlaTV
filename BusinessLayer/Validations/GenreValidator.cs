using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class GenreValidator:AbstractValidator<Genre>

    {
        public GenreValidator()
        {
            RuleFor(m=>m.GenreName).NotEmpty().WithMessage("this field cannot be left blank");
        }
    }
}
