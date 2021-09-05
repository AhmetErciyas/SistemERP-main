using ERP.Application.DTOs.IstenAyrılmaNedenleriDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.IstenAyrilmaNedenleriValidation.IstenAyrilmaNedenleri
{
    public class IstenAyrilmaNedenEkleValidator : BaseValidator<IstenAyrilmaNedenleriEkleDTO>
    {
        public IstenAyrilmaNedenEkleValidator()
        {
            RuleFor(x => x.adi).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Adi");
        }
    }
}
