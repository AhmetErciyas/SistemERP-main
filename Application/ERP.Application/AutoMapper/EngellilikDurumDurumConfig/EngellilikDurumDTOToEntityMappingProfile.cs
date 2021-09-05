using AutoMapper;
using ERP.Application.DTOs.EngellilikDurumDTOs;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.EngellilikDurumDurumConfig
{
    public class EngellilikDurumDTOToEntityMappingProfile : Profile
    {
        public EngellilikDurumDTOToEntityMappingProfile()
        {
            CreateMap<EngellilikDurumDto, engellilikDurum>();

        }
    }
}
