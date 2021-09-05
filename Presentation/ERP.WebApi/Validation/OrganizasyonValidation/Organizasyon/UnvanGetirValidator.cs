using FluentValidation;

namespace ERP.WebApi.Validation.OrganizasyonValidation
{
    public class UnvanGetirValidator : BaseValidator<int>
    {
        public UnvanGetirValidator()
        {
            RuleFor(x => x).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Unvan Id ");
            RuleFor(x => x).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Unvan Id ");
        }
    }
}