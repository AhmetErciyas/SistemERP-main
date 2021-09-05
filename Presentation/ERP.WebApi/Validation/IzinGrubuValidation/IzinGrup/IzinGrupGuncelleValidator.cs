using ERP.Application.DTOs.IzinGrupDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.IzinGrubuValidation.IzinGrup
{
    public class IzinGrupGuncelleValidator : BaseValidator<IzinGrupGuncelleDTO>
    {
        public IzinGrupGuncelleValidator()
        {
            RuleFor(x => x.id).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("İzin Grup Id ");
            RuleFor(x => x.adi).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("İzin Grup Adi ");
            RuleFor(x => x.id).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("İzin Grup Id ");
        }
    }
}