using AutoMapper;
using ERP.Application.DTOs.PersonelKimlikBilgileriDTOs;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.PersonelKimlikConfig
{
    public class PersonelKimlikDTOToEntityMappingProfile : Profile
    {
        public PersonelKimlikDTOToEntityMappingProfile()
        {
            //CreateMap<KullaniciYetkiDTO, kullaniciYetkileri>();
            CreateMap<PersonelKimlikBilgileriEkleDTO, personelKimlik>();
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
            CreateMap<PersonelKimlikBilgileriGuncelleDTO, personelKimlik>();
        }
    }
}