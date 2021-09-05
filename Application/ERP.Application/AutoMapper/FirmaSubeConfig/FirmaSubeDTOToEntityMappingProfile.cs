using AutoMapper;
using ERP.Application.DTOs.FirmaSubeDTOs;
using ERP.Data.DAO.FirmaSube;
using ERP.Data.Entities;
using ERP.Domain.Commands;
using ERP.Domain.Commands.Personel;
using System;
using System.Collections.Generic;
using System.Text;
using static ERP.Application.DTOs.FirmaSubeDTOs.FirmaSubeDTO;

namespace ERP.Application.AutoMapper.FirmaSubeConfig
{
   public  class FirmaSubeDTOToEntityMappingProfile : Profile
    {
        public FirmaSubeDTOToEntityMappingProfile()
        {
            CreateMap<FirmaSubeEkleDTO, sube>();
            CreateMap<FirmaSubeEkleDTO, FirmaSubeEkleCommand>()
                .ForMember(dest => dest.FirmaSube, opt =>
                {
                    opt.MapFrom(src => src);
                });

            CreateMap<FirmaSubeAraDTO, FirmaSubeAraDAO>();
            CreateMap<FirmaSubeAraDTO, FirmaSubeAraQuery>()
                .ForMember(dest => dest.FirmaSube, opt =>
                {
                    opt.MapFrom(src => src);
                });

            CreateMap<FirmaSubeGuncelleDTO, sube>();
            CreateMap<FirmaSubeGuncelleDTO, FirmaSubeGuncelleCommand>()
                .ForMember(dest => dest.FirmaSube, opt =>
                {
                    opt.MapFrom(src => src);
                });


            CreateMap<FirmaSubeDTO, FirmaSubeEkleCommand>();


            

        }
    }
}
