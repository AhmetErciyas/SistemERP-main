using AutoMapper;
using ERP.Application.DTOs.YetkiGruplariDetayDTOs;
using ERP.Data.DAO.YetkiGruplariDetay;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.YetkiGruplariDetayConfig
{
    public class YetkiGruplariDetayEntityToDTOMappingProfile : Profile
    {
        public YetkiGruplariDetayEntityToDTOMappingProfile()
        {
            CreateMap<yetkiGruplariDetay, YetkiGrupDetayDTO>();

            CreateMap<YetkiGruplariDetayDAO, YetkiGrupDetayDTO>();


        }
    }
}
