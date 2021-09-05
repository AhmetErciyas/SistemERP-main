using AutoMapper;
using ERP.Application.DTOs.IzinGrupDTOs;
using ERP.Data.DAO.IzinGrup;
using ERP.Data.Entities;
using ERP.Domain.Commands.IzinGrup;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.IzinGrupConfig
{
    public class IzinGrupDTOToEntityMappingProfile:Profile
    {
        public IzinGrupDTOToEntityMappingProfile()
        {
            CreateMap<IzinGrupDTO, izinGrubu>();
            CreateMap<IzinGrupDTO, IzinGrupDAO>();
            CreateMap<IzinGrupGuncelleDTO, izinGrubu>();
            CreateMap<IzinGrupEkleDTO, izinGrubu>();
            CreateMap<IzinGrupEkleDTO, IzinGrupEkleCommand>()
                .ForMember(dest => dest.izinGrubu, opt =>
                {
                    opt.MapFrom(src => src);
                });
            CreateMap<IzinGrupGuncelleDTO, IzinGrupGuncelleCommand>()
                .ForMember(dest => dest.izinGrubu, opt =>
                {
                    opt.MapFrom(src => src);
                });
            //CreateMap<KademeDTO, KademeAraQuery>()
            //   .ForMember(dest => dest.Kademe, opt =>
            //   {
            //       opt.MapFrom(src => src);
            //   });
        }
           
    }
}
