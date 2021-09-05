using ERP.Application.DTOs.IzinGrupDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.IzinGrubuValidation.IzinGrup
{
    public class IzinGrupEkleValidator : BaseValidator<IzinGrupEkleDTO>
    {
        public IzinGrupEkleValidator()
        {
            RuleFor(x => x.adi).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Adi");
        }
    }
}