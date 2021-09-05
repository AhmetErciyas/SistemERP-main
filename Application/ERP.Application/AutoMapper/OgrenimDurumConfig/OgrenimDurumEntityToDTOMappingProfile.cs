using AutoMapper;
using ERP.Application.DTOs.OgrenimDurumDTOs;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.OgrenimDurumConfig
{
    public class OgrenimDurumEntityToDTOMappingProfile : Profile
    {
        public OgrenimDurumEntityToDTOMappingProfile()
        {
            CreateMap<ogrenimDurum, OgrenimDurumDTO>()
                .ForMember(dest => dest.id, opt =>
                {
                    opt.MapFrom(src => src.id);
                })
                .ForMember(dest => dest.adi, opt =>
                {
                    opt.MapFrom(src => src.adi);
                });


        }
    }
}
