using FluentValidation;

namespace ERP.WebApi.Validation.OrganizasyonValidation
{
    public  class DepartmanGetirValidator:BaseValidator<int>
    {
        public DepartmanGetirValidator()
        {
            RuleFor(x => x).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Departman Id ");
            RuleFor(x => x).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Departman Id ");

        }
    }
}