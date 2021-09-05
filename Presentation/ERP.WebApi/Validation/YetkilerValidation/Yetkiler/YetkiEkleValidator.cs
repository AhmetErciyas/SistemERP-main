using ERP.Application.DTOs.YetkilerDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.YetkilerValidation.Yetkiler
{
    public class YetkiEkleValidator : BaseValidator<YetkiEkleDTO>
    {
        public YetkiEkleValidator()
        {
            RuleFor(x => x.adi).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Adi");
        }
    }
}
