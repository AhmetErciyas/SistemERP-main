using ERP.Application.DTOs.IstenAyrılmaNedenleriDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.IstenAyrilmaNedenleriValidation.IstenAyrilmaNedenleri
{
    public class IstenAyrilmaNedenGuncelleValidator : BaseValidator<IstenAyrilmaNedenleriGuncelleDTO>
    {
        public IstenAyrilmaNedenGuncelleValidator()
        {
            RuleFor(x => x.id).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Kademe Id ");
            RuleFor(x => x.adi).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Kadene Adi ");
            RuleFor(x => x.id).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Kademe Id ");
        }
    }
}