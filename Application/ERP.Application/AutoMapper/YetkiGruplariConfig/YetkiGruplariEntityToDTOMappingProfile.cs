using AutoMapper;
using ERP.Application.DTOs.YetkiGruplariDTOs;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.YetkiGruplariConfig
{
    public class YetkiGruplariEntityToDTOMappingProfile : Profile
    {
        public YetkiGruplariEntityToDTOMappingProfile()
        {
            CreateMap<yetkiGruplari, YetkiGrupDTO>();

            //CreateMap<DepartmanDAO, DepartmanDTO>();


        }
    }
}