using AutoMapper;
using ERP.Application.DTOs.YetkiGruplariDetayDTOs;
using ERP.Application.DTOs.YetkiGruplariDTOs;
using ERP.Data.Entities;
using ERP.Domain.Commands.YetkiGruplari;
using ERP.Domain.Commands.YetkiGruplariDetay;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.YetkiGruplariDetayConfig
{
    public class YetkiGruplariDetayDTOToEntityMappingProfile : Profile
    {
        public YetkiGruplariDetayDTOToEntityMappingProfile()
        {
            //CreateMap<KullaniciYetkiDTO, DepartmanDAO>();
            CreateMap<YetkiGrupDetayDTO, yetkiGruplariDetay>();
            CreateMap<YetkiGrupDetayEkleDTO, yetkiGruplariDetay>();
            CreateMap<YetkiGrupDetayEkleDTO, YetkiGruplariDetayEkleCommand>()
                .ForMember(dest => dest.yetkiGruplariDetay, opt =>
                {
                    opt.MapFrom(src => src);
                });
            CreateMap<YetkiGrupDetayGuncelleDTO, YetkiGruplariDetayGuncelleCommand>()
                .ForMember(dest => dest.yetkiGruplariDetay, opt =>
                {
                    opt.MapFrom(src => src);
                });
            CreateMap<YetkiGrupDetayGuncelleDTO, yetkiGruplariDetay>();

            //CreateMap<YetkiGrupDTO, departman>();
            //CreateMap<KullaniciYetkiDTO, DepartmanAraQuery>()
            //    .ForMember(dest => dest.Departman, opt =>
            //    {
            //        opt.MapFrom(src => src);
            //    });
        }
    }
}

