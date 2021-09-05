using AutoMapper;
using ERP.Application.DTOs.PersonelAgiDTOs;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.PersonelAgiConfig
{
    public class PersonelAgiDTOToEntityMappingProfile : Profile
    {
        public PersonelAgiDTOToEntityMappingProfile()
        {
            //CreateMap<KullaniciYetkiDTO, kullaniciYetkileri>();
            CreateMap<PersonelAgiEkleDto, personelAgi>();
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
            CreateMap<PersonelAgiGuncelleDto, personelAgi>();
        }
    }
}
