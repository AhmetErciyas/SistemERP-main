using AutoMapper;
using ERP.Application.DTOs.PersonelEmeklilikDTOs;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.PersonelEmeklilikConfig
{
    public class PersonelEmeklilikDTOToEntityMappingProfile : Profile
    {
        public PersonelEmeklilikDTOToEntityMappingProfile()
        {
            //CreateMap<KullaniciYetkiDTO, kullaniciYetkileri>();
            CreateMap<PersonelEmeklilikEkleDTO, personelEmeklilik>();
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
            CreateMap<PersonelEmeklilikGuncelleDTO, personelEmeklilik>();
        }
    }
}
