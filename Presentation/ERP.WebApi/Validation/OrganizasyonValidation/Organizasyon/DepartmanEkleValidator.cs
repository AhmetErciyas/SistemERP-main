using ERP.Application.DTOs.OrganizasyonDTOs;
using FluentValidation;

namespace ERP.WebApi.Validation.OrganizasyonValidation
{
    public  class DepartmanEkleValidator : BaseValidator<DepartmanEkleDTO>
    {
        public DepartmanEkleValidator()
        {
            RuleFor(x => x.adi).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Adi");
            RuleFor(x => x.bolumid).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Bölüm");

        }
    }
}