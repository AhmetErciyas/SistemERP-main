using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.YetkilerValidation.Yetkiler
{
    public class YetkiSilValidator : BaseValidator<int>
    {
        public YetkiSilValidator()
        {
            RuleFor(x => x).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Yetki Id");
            RuleFor(x => x).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Yetki Id");

        }
    }
}
