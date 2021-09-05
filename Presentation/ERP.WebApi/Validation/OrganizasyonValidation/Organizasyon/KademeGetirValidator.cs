using FluentValidation;

namespace ERP.WebApi.Validation.OrganizasyonValidation
{
    public class KademeGetirValidator : BaseValidator<int>
    {
        public KademeGetirValidator()
        {

            RuleFor(x => x).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Kademe Id ");
            RuleFor(x => x).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Kademe Id ");

        }
    }
}