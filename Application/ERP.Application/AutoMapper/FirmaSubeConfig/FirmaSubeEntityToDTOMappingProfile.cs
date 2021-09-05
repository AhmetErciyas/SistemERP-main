using AutoMapper;
using ERP.Application.DTOs.FirmaSubeDTOs;
using ERP.Data.DAO.FirmaSube;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.FirmaSubeConfig
{
    public class FirmaSubeEntityToDTOMappingProfile : Profile
    {
        public FirmaSubeEntityToDTOMappingProfile()
        {
            CreateMap<sube, FirmaSubeDTO>()
                .ForMember(dest => dest.Adi, opt =>
                {
                    opt.MapFrom(src => src.adi);
                })
                .ForMember(dest => dest.FirmaId, opt =>
                {
                    opt.MapFrom(src => src.firmaid);
                })
                 .ForMember(dest => dest.Id, opt =>
                 {
                     opt.MapFrom(src => src.id);
                 });
               

            CreateMap<FirmaSubeDAO, FirmaSubeDTO>();
            CreateMap<FirmaSubeAraDAO, FirmaSubeAraDTO>();

        }
    }
}
