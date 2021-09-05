using AutoMapper;
using ERP.Application.DTOs.PersonelDepartmanDTOs;
using ERP.Data.DAO.PersonelDepartman;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.PersonelDepartmanConfig
{
    public class PersonelDepartmanEntityToDTOMappingProfile : Profile
    {
        public PersonelDepartmanEntityToDTOMappingProfile()
        {
            CreateMap<personelDepartman, PersonelDepartmanEkleDTO>();
            CreateMap<personelDepartman, PersonelDepartmanGuncelleDTO>();
            CreateMap<PersonelDepartmanDAO, PersonelDepartmanDTO>();

        }
    }
}