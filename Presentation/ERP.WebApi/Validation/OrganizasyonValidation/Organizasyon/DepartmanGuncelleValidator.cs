using ERP.Application.DTOs.OrganizasyonDTOs;
using FluentValidation;

namespace ERP.WebApi.Validation.OrganizasyonValidation
{
    public class DepartmanGuncelleValidator: BaseValidator<DepartmanDTO>
    {
        public DepartmanGuncelleValidator()
        {
            RuleFor(x => x.id).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Departman Id ");
            RuleFor(x => x.id).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Departman Id ");
            RuleFor(x => x.bolumid).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Bolum Id ");
        }
    }
}