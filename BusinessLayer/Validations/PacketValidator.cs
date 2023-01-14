using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class PacketValidator:AbstractValidator<Packet>
    {
        public PacketValidator() 
        {
            RuleFor(m => m.PacketName).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.ViewCount).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.PacketPrice).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.PacketContentQuality).NotEmpty().WithMessage("this field cannot be left blank");
            RuleFor(m => m.PacketExplanation).NotEmpty().WithMessage("this field cannot be left blank");


        }
    }
}
