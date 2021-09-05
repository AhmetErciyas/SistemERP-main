using ERP.Application.DTOs.FirmaSubeDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ERP.Application.DTOs.FirmaSubeDTOs.FirmaSubeDTO;

namespace ERP.WebApi.Validation.FirmaSubeValidation.FirmaSube
{
    public class FirmaSubeEkleValidator : BaseValidator<FirmaSubeEkleDTO>
    {
        public FirmaSubeEkleValidator()
        {
            RuleFor(x => x.Adi).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Adi");
            RuleFor(x => x.FirmaId).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Firma");

            RuleFor(x => x.FirmaId).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Firma");

    

            
        }
    }
}
