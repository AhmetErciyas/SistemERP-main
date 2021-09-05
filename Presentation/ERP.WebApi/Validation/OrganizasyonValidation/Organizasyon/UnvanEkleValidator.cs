using ERP.Application.DTOs.OrganizasyonDTOs;
using FluentValidation;

namespace ERP.WebApi.Validation.OrganizasyonValidation
{
    public class UnvanEkleValidator : BaseValidator<UnvanEkleDTO>
    {
        public UnvanEkleValidator()
        {
            RuleFor(x => x.adi).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Unvan Adi");
          
        }
    }
}