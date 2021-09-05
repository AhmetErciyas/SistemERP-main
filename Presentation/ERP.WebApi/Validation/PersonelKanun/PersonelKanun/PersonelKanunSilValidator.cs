using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.PersonelKanun.PersonelKanun
{
    public class PersonelKanunSilValidator : BaseValidator<int>
    {
        public PersonelKanunSilValidator()
        {

            RuleFor(x => x).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Personel Kanun Id ");
            RuleFor(x => x).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Personel Kanun Id ");

        }
    }
}
