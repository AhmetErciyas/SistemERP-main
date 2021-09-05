using FluentValidation;

namespace ERP.WebApi.Validation
{
    public class PersonelGetirValidator : BaseValidator<int>
    {
        public PersonelGetirValidator()
        {
            RuleFor(x => x).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Personel Id ");
            RuleFor(x => x).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Personel Id ");
        }
    }
}
