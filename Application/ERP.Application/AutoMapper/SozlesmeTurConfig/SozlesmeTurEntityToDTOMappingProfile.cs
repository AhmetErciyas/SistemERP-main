using AutoMapper;
using ERP.Application.DTOs.SozlesmeTurDTOs;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.SozlesmeTurConfig
{
    class SozlesmeTurEntityToDTOMappingProfile : Profile
    {
        public SozlesmeTurEntityToDTOMappingProfile()
        {
            CreateMap<sozlesmeTur, SozlesmeTurDTO>()
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