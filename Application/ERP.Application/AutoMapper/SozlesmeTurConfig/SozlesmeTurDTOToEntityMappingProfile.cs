using AutoMapper;
using ERP.Application.DTOs.SozlesmeTurDTOs;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.SozlesmeTurConfig
{
    public class SozlesmeTurDTOToEntityMappingProfile : Profile
    {
        public SozlesmeTurDTOToEntityMappingProfile()
        {
            CreateMap<SozlesmeTurDTO, sozlesmeTur>();

        }
    }
}
