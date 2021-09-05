using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.KullaniciYetkileriValidation.KullaniciYetkileri
{
    public class KullaniciYetkiSilValidator : BaseValidator<int>
    {
        public KullaniciYetkiSilValidator()
        {
            RuleFor(x => x).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Kullanici Yetki Id ");
            RuleFor(x => x).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Kullanici Yetki Id ");

        }
    }
}
