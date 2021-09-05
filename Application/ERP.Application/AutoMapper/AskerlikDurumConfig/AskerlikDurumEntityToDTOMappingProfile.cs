using AutoMapper;
using ERP.Application.DTOs.AskerlikDurumDTOs;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.AskerlikDurumConfig
{
    public class AskerlikDurumEntityToDTOMappingProfile:Profile
    {
        public AskerlikDurumEntityToDTOMappingProfile()
        {
            CreateMap<askerlikDurum, AskerlikDurumDTO>()
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
