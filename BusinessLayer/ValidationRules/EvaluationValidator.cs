using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class EvaluationValidator : AbstractValidator<Evaluation>
    {
        public EvaluationValidator()
        {
            RuleFor(x => x.EvaluationTitle).NotEmpty().WithMessage("Title cannot be null!");
            RuleFor(x => x.EvaluationContent).NotEmpty().WithMessage("Content cannot be null!");
            RuleFor(x => x.EvaluationImage).NotEmpty().WithMessage("Image cannot be null!");
            RuleFor(x => x.EvaluationTitle).MaximumLength(150).WithMessage("Please using maximum 150 character for title!");
            RuleFor(x => x.EvaluationTitle).MinimumLength(5).WithMessage("Please using minimum 5 character for title!");
        }
    }
}
