using AutoMapper;
using ERP.Application.DTOs.PersonelEmeklilikDTOs;
using ERP.Data.DAO.PersonelEmeklilik;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.PersonelEmeklilikConfig
{
    public class PersonelEmeklilikEntityToDTOMappingProfile : Profile
    {
        public PersonelEmeklilikEntityToDTOMappingProfile()
        {
            CreateMap<personelEmeklilik, PersonelEmeklilikEkleDTO>();
            CreateMap<personelEmeklilik, PersonelEmeklilikGuncelleDTO>();
            CreateMap<PersonelEmeklilikDAO, PersonelEmeklilikDTO>();

        }
    }
}