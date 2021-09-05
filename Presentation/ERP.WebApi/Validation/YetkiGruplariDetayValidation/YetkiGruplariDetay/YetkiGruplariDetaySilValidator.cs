using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.YetkiGruplariDetayValidation.YetkiGruplariDetay
{
    public class YetkiGruplariDetaySilValidator : BaseValidator<int>
    {
        public YetkiGruplariDetaySilValidator()
        {
            RuleFor(x => x).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Yetki Gruplari Detay Id ");
            RuleFor(x => x).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Yetki Gruplari Detay Id");

        }
    }
}
