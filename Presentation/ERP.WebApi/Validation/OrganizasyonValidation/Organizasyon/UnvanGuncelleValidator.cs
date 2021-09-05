using ERP.Application.DTOs.OrganizasyonDTOs;
using FluentValidation;

namespace ERP.WebApi.Validation.OrganizasyonValidation
{
    public class UnvanGuncelleValidator : BaseValidator<UnvanDTO>
    {
        public UnvanGuncelleValidator()
        {
            RuleFor(x => x.id).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Unvan Id ");
            RuleFor(x => x.id).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Unvan Id ");
        }
    }
}