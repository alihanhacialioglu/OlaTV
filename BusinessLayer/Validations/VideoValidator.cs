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
            RuleFor(m => m.VideoUrl).NotEmpty().WithMessage("Video Url cannot be empty");
            RuleFor(m=>m.ReleaseDate).NotEmpty().WithMessage("Release Date cannot be empty");
			RuleFor(m => m.SeasonNo).NotEmpty().WithMessage("Season No cannot be empty");
            RuleFor(m => m.EpisodeNo).NotEmpty().WithMessage("Episode No cannot be empty");
            RuleFor(m => m.LanguageId).NotEmpty().WithMessage("Language cannot be empty");    
            RuleFor(m => m.ContentId).NotEmpty().WithMessage("Content cannot be empty");
            RuleFor(m => m.CategoryId).NotEmpty().WithMessage("Category cannot be empty");    
        }
    }
}
