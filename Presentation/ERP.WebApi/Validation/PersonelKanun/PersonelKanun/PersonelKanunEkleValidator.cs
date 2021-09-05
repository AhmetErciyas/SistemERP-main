using ERP.Application.DTOs.PersonelKanun;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.PersonelKanun.PersonelKanun
{
    public class PersonelKanunEkleValidator : BaseValidator<PersonelKanunEkleDTO>
    {
        public PersonelKanunEkleValidator()
        {
            RuleFor(x => x.adi).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Adi");
        }
    }
}
