using AutoMapper;
using ERP.Application.DTOs.PersonelEkGelirGiderDTOs;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.PersonelEkGelirGiderConfig
{
   public  class PersonelEkGelirGiderDTOToEntityMappingProfile : Profile
    {
        public PersonelEkGelirGiderDTOToEntityMappingProfile()
        {
            //CreateMap<KullaniciYetkiDTO, kullaniciYetkileri>();
            CreateMap<PersonelEkGelirGiderEkleDTO, ekGelirGider>();
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
            CreateMap<PersonelEkGelirGiderGuncelleDTO, ekGelirGider>();
        }
    }
}
