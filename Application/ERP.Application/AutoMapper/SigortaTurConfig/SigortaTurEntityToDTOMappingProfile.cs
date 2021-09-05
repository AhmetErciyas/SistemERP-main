using AutoMapper;
using ERP.Application.DTOs.SigortaTurDTOs;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.SigortaTurConfig
{
    public class SigortaTurEntityToDTOMappingProfile : Profile
    {
        public SigortaTurEntityToDTOMappingProfile()
        {
            CreateMap<sigortaTur, SigortaTurDTO>()
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
