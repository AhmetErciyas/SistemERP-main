using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.IzinGrubuValidation.IzinGrup
{
    public class IzinGrupSilValidator : BaseValidator<int>
    {
        public IzinGrupSilValidator()
        {

            RuleFor(x => x).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("İzin Grup Id ");
            RuleFor(x => x).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("İzin Grup Id");

        }
    }
}