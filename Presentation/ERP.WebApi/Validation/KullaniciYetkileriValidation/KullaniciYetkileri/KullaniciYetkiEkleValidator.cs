using ERP.Application.DTOs.KullaniciYetkileriDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.WebApi.Validation.KullaniciYetkileriValidation.KullaniciYetkileri
{
    public class KullaniciYetkiEkleValidator : BaseValidator<KullaniciYetkiEkleDTO>
    {
        public KullaniciYetkiEkleValidator()
        {
            RuleFor(x => x.kullaniciId).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Kullanici Id");
            RuleFor(x => x.yetkiId).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Yetki Id");
            RuleFor(x => x.kullaniciId).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Kullanici Id ");
            RuleFor(x => x.yetkiId).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Yetki Id ");

        }
    }
}