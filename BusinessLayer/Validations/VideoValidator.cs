using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class VideoValidator : AbstractValidator<Video>
    {
        public VideoValidator()
        {
            RuleFor(m => m.VideoUrl).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m=>m.ReleaseDate).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.SeasonNo).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.EpisodeNo).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.LanguageId).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.ContentId).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.CategoryId).NotEmpty().WithMessage("this field cannot be left blank");    
        }
    }
}
