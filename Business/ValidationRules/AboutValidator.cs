using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description Cannot be Empty!");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Please! Select Image!");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Enter at least 50 characters");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Up To 1500 characters");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title Cannot Be Empty!");
            
            
            
            
        }

    }
}
