using AutoMapper;
using ERP.Application.DTOs.PersonelMaasDTOs;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.PersonelMaasConfig
{
    public class PersonelMaasDTOToEntityMappingProfile : Profile
    {
        public PersonelMaasDTOToEntityMappingProfile()
        {
            //CreateMap<KullaniciYetkiDTO, kullaniciYetkileri>();
            CreateMap<PersonelMaasEkleDTO, personelMaas>();
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
            CreateMap<PersonelMaasGuncelleDTO, personelMaas>();
        }
    }
}