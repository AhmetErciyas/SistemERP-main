using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.IstenAyrilmaNedenleriValidation.IstenAyrilmaNedenleri
{
    public class IstenAyrilmaNedenSilValidator : BaseValidator<int>
    {
        public IstenAyrilmaNedenSilValidator()
        {

            RuleFor(x => x).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Isten Ayrilma Neden Id ");
            RuleFor(x => x).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Isten Ayrilma Neden Id ");

        }
    }
}
