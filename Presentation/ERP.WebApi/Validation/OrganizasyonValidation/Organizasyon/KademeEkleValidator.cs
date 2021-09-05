using ERP.Application.DTOs.OrganizasyonDTOs;
using FluentValidation;

namespace ERP.WebApi.Validation.OrganizasyonValidation
{
    public class KademeEkleValidator : BaseValidator<KademeEkleDTO>
    {
        public KademeEkleValidator()
        {
            RuleFor(x => x.adi).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Adi");
        }
    }
}