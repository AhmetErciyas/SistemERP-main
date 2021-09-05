using AutoMapper;
using ERP.Application.DTOs.PersonelDiğerBilgileriDTOS;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.PersonelDiğerBilgilerConfig
{
    public class PersonelDigerBilgilerDTOToEntityMappingProfile : Profile
    {
        public PersonelDigerBilgilerDTOToEntityMappingProfile()
        {
            //CreateMap<KullaniciYetkiDTO, kullaniciYetkileri>();
            CreateMap<PersonelDiğerBilgileriEkleDTO, digerBilgiler>();
            //CreateMap<KullaniciYetkiEkleDTO, KullaniciYetkileriEkleCommand>()
            //    .ForMember(dest => dest.kullaniciYetkileri, opt =>
            //    {
            //        opt.MapFrom(src => src);
            //    });
            //CreateMap<KullaniciYetkiGuncelleDTO, KullaniciYetkileriGuncelleCommand>()

            //    .ForMember(dest => dest.kullaniciYetkileri, opt =>
            //    {
            //        opt.MapFrom(src => src);
            //    });
            CreateMap<PersonelDiğerBilgileriGuncelleDTO, digerBilgiler>();
        }
    }
}