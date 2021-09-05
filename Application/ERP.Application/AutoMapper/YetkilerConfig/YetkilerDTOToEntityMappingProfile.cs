using AutoMapper;
using ERP.Application.DTOs.YetkilerDTOs;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.YetkilerConfig
{
    public class YetkilerDTOToEntityMappingProfile : Profile
    {
        public YetkilerDTOToEntityMappingProfile()
        {
            //CreateMap<KullaniciYetkiDTO, DepartmanDAO>();
            CreateMap<YetkiDTO, yetkiler>();
            CreateMap<YetkiEkleDTO, yetkiler>();
            //CreateMap<YetkiEkleDTO, YetkiEkleCommand>()
            //    .ForMember(dest => dest.kullaniciYetkileri, opt =>
            //    {
            //        opt.MapFrom(src => src);
            //    });
            //CreateMap<KullaniciYetkiDTO, KullaniciYetkileriGuncelleCommand>()
            //    .ForMember(dest => dest.kullaniciYetkileri, opt =>
            //    {
            //        opt.MapFrom(src => src);
            //    });
            //CreateMap<YetkiDTO, departman>();
            //CreateMap<KullaniciYetkiDTO, DepartmanAraQuery>()
            //    .ForMember(dest => dest.Departman, opt =>
            //    {
            //        opt.MapFrom(src => src);
            //    });
        }
    }
}
