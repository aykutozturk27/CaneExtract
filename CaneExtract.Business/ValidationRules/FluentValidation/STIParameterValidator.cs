using CaneExtract.Business.Constants;
using CaneExtract.Entities.Dtos;
using FluentValidation;

namespace CaneExtract.Business.ValidationRules.FluentValidation
{
    public class STIParameterValidator : AbstractValidator<STIWithSTKParameterDto>
    {
        public STIParameterValidator()
        {
            //RuleFor(x => x.CommodityCode).NotEmpty().WithMessage(Messages.CommodityCodeIsNotEmpty);
            RuleFor(x => x.StartDate).NotEmpty().WithMessage(Messages.StartDateIsNotEmpty);
            RuleFor(x => x.EndDate).NotEmpty().WithMessage(Messages.EndDateIsNotEmpty);
        }
    }
}
