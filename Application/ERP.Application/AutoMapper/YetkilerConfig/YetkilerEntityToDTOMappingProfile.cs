using AutoMapper;
using ERP.Application.DTOs.YetkilerDTOs;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.YetkilerConfig
{
    public class YetkilerEntityToDTOMappingProfile : Profile
    {
        public YetkilerEntityToDTOMappingProfile()
        {
            CreateMap<yetkiler, YetkiDTO>();

            //CreateMap<DepartmanDAO, DepartmanDTO>();


        }
    }
}

