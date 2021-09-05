using ERP.Application.DTOs.YetkilerDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.YetkilerValidation.Yetkiler
{
    public class YetkiGuncelleValidator : BaseValidator<YetkiGuncelleDTO>
    {
        public YetkiGuncelleValidator()
        {
            RuleFor(x => x.adi).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Adi");
            RuleFor(x => x.Id).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Yetki Id");
        }
    }
}
