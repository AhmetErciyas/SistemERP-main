using AutoMapper;
using ERP.Application.DTOs.YetkiGruplariDTOs;
using ERP.Data.Entities;
using ERP.Domain.Commands.YetkiGruplari;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.YetkiGruplariConfig
{
    public class YetkiGruplariDTOToEntityMappingProfile : Profile
    {
        public YetkiGruplariDTOToEntityMappingProfile()
        {
            //CreateMap<KullaniciYetkiDTO, DepartmanDAO>();
            CreateMap<YetkiGrupDTO, yetkiGruplari>();
            CreateMap<YetkiGrupEkleDTO, yetkiGruplari>();
            CreateMap<YetkiGrupEkleDTO, YetkiGruplariEkleCommand>()
                .ForMember(dest => dest.yetkiGruplari, opt =>
                {
                    opt.MapFrom(src => src);
                });
            CreateMap<YetkiGrupGuncelleDTO, YetkiGruplariGuncelleCommand>()
                .ForMember(dest => dest.yetkiGruplari, opt =>
                {
                    opt.MapFrom(src => src);
                });
            //CreateMap<YetkiGrupGuncelleDTO, YetkiGrupDTO>();
            CreateMap<YetkiGrupGuncelleDTO, yetkiGruplari>();

            //CreateMap<YetkiGrupDTO, departman>();
            //CreateMap<KullaniciYetkiDTO, DepartmanAraQuery>()
            //    .ForMember(dest => dest.Departman, opt =>
            //    {
            //        opt.MapFrom(src => src);
            //    });
        }
    }
}