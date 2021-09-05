using ERP.Application.DTOs.YetkiGruplariDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.YetkiGruplariValidation.YetkiGruplari
{
    public class YetkiGruplariGuncelleValidator : BaseValidator<YetkiGrupGuncelleDTO>
    {
        public YetkiGruplariGuncelleValidator()
        {
            RuleFor(x => x.adi).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Adi");
            RuleFor(x => x.id).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Yetki Grup Id ");
        }
    }
}