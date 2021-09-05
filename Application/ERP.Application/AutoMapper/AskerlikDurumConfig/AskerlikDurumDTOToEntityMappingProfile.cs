using AutoMapper;
using ERP.Application.DTOs.AskerlikDurumDTOs;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.AskerlikDurumConfig
{
    public class AskerlikDurumDTOToEntityMappingProfile: Profile
    {
        public AskerlikDurumDTOToEntityMappingProfile()
        {
            CreateMap<AskerlikDurumDTO, askerlikDurum>();
            
        }
    }
}
