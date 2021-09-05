using ERP.Application.DTOs.PersonelDTOs;
using FluentValidation;
using System;

namespace ERP.WebApi.Validation
{
    public class PersonelEkleValidator : BaseValidator<PersonelEkleDTO>
    {
        public PersonelEkleValidator()
        {
            RuleFor(x => x.adi).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("İsim");
            RuleFor(x => x.soyadi).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Soyisim");

            RuleFor(x => x.kademeid).NotNull().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Kademe");
            RuleFor(x => x.kademeid).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Kademe");

            //RuleFor(x => x.KademeId).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Kademe");
            //RuleFor(x => x.KademeId).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Kademe");

            RuleFor(x => x.unvanid).NotEmpty().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Ünvan");
            RuleFor(x => x.unvanid).GreaterThan(0).WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Ünvan");

            RuleFor(x => x.iseGirisTarih).NotNull().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("İşe başlama tarih");
            RuleFor(x => x.iseGirisTarih).GreaterThan(DateTime.Now.AddDays(-7)).WithMessage("İşe başlama tarih 1 hafta öncesinden daha eski bir tarih olamaz");

            RuleFor(x => x.engellilikDurumid).NotNull().WithMessage(NOT_EMPTY_ERROR_MESSAGE).WithName("Durum");
        }
    }
}
