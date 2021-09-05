using AutoMapper;
using ERP.Application.DTOs.EngellilikDurumDTOs;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.EngellilikDurumDurumConfig
{
    public class EngellilikDurumEntityToDTOMappingProfile : Profile
    {
        public EngellilikDurumEntityToDTOMappingProfile()
        {
            CreateMap<engellilikDurum, EngellilikDurumDto>()
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
