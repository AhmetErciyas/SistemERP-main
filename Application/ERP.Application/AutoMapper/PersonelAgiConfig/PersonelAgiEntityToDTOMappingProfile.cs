using AutoMapper;
using ERP.Application.DTOs.PersonelAgiDTOs;
using ERP.Data.DAO.PersonelAgi;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.PersonelAgiConfig
{
    public class PersonelAgiEntityToDTOMappingProfile : Profile
    {
        public PersonelAgiEntityToDTOMappingProfile()
        {
            CreateMap<personelAgi, PersonelAgiEkleDto>();
            CreateMap<personelAgi, PersonelAgiGuncelleDto>();

            CreateMap<PersonelAgiDAO, PersonelAgiDto>();
        }
    }
}