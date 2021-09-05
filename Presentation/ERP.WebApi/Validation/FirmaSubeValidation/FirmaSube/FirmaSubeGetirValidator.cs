using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.FirmaSubeValidation.FirmaSube
{
    public class FirmaSubeGetirValidator : BaseValidator<int>
    {
        public FirmaSubeGetirValidator()
        {
            RuleFor(x => x).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Firma Sube Id ");
            RuleFor(x => x).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Firma Sube Id ");
        }
    }
}
