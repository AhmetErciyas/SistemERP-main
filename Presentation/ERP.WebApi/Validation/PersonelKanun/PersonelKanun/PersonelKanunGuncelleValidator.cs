using ERP.Application.DTOs.PersonelKanun;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.PersonelKanun.PersonelKanun
{
    public class PersonelKanunGuncelleValidator : BaseValidator<PersonelKanunGuncelleDTO>
    {
        public PersonelKanunGuncelleValidator()
        {
            RuleFor(x => x.id).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Personel Kanun Id ");
            RuleFor(x => x.adi).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Personel Kanun Adi ");
            RuleFor(x => x.id).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Personel Kanun Id ");
        }
    }
}
