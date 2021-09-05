using AutoMapper;
using ERP.Application.DTOs.SigortaTurDTOs;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.SigortaTurConfig
{
    public class SigortaTurDTOToEntityMappingProfile : Profile
    {
        public SigortaTurDTOToEntityMappingProfile()
        {
            CreateMap<SigortaTurDTO, sigortaTur>();

        }
    }
}
