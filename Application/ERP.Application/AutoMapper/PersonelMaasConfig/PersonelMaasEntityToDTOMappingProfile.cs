using AutoMapper;
using ERP.Application.DTOs.PersonelMaasDTOs;
using ERP.Data.DAO.PersonelMaas;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.PersonelMaasConfig
{
    public class PersonelMaasEntityToDTOMappingProfile : Profile
    {
        public PersonelMaasEntityToDTOMappingProfile()
        {
            CreateMap<personelMaas, PersonelMaasEkleDTO>();
            CreateMap<personelMaas, PersonelMaasGuncelleDTO>();
            CreateMap<PersonelMaasDAO, PersonelMaasDTO>();

        }
    }
}