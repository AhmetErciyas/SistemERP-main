using ERP.Application.DTOs.PersonelDTOs;
using FluentValidation;
using System;

namespace ERP.WebApi.Validation
{
    public class PersonelGuncelleValidator : BaseValidator<PersonelGuncelleDTO>
    {
        public PersonelGuncelleValidator()
        {
            //RuleFor(x => x.KisiId).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Kişi ");
            //RuleFor(x => x.KisiId).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Kişi ");

            //RuleFor(x => x.KademeId).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Kademe");
            //RuleFor(x => x.KademeId).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Kademe");

            //RuleFor(x => x.UnvanId).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Ünvan");
            //RuleFor(x => x.UnvanId).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Ünvan");

            //RuleFor(x => x.DurumId).NotNull().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Durum");
        }
    }
}
