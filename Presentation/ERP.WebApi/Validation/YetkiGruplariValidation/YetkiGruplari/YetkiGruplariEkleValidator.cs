using ERP.Application.DTOs.YetkiGruplariDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.YetkiGruplariValidation.YetkiGruplari
{
    public class YetkiGruplariEkleValidator : BaseValidator<YetkiGrupEkleDTO>
    {
        public YetkiGruplariEkleValidator()
        {
            RuleFor(x => x.adi).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Adi");
        }
    }
}
