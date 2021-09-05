using ERP.Application.DTOs.FirmaSubeDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ERP.Application.DTOs.FirmaSubeDTOs.FirmaSubeDTO;

namespace ERP.WebApi.Validation.FirmaSubeValidation.FirmaSube
{
    public class FirmaSubeGuncelleValidator : BaseValidator<FirmaSubeGuncelleDTO>
    {
        public FirmaSubeGuncelleValidator()
        {
            RuleFor(x => x.adi).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Adi");
            RuleFor(x => x.firmaid).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Firma");
            RuleFor(x => x.firmaid).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Firma");

        }
    }
}
