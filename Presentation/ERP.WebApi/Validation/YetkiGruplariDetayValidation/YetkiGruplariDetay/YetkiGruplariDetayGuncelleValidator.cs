using ERP.Application.DTOs.YetkiGruplariDetayDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.YetkiGruplariDetayValidation.YetkiGruplariDetay
{
    public class YetkiGruplariDetayGuncelleValidator : BaseValidator<YetkiGrupDetayGuncelleDTO>
    {
        public YetkiGruplariDetayGuncelleValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Grup Gruplari Detay Id");
            RuleFor(x => x.Id).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Yetki Gruplari Detay Id ");
            RuleFor(x => x.GrupId).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Grup Id");
            RuleFor(x => x.YetkiId).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Yetki Id");
            RuleFor(x => x.GrupId).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Grup Id ");
            RuleFor(x => x.YetkiId).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Yetki Id ");
        }
    }
}
