using AutoMapper;
using ERP.Application.DTOs.OgrenimDurumDTOs;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.OgrenimDurumConfig
{
    public class OgenimDurumDTOToEntityMappingProfile : Profile
    {
        public OgenimDurumDTOToEntityMappingProfile()
        {
            CreateMap<OgrenimDurumDTO, ogrenimDurum>();

        }
    }
}
