using AutoMapper;
using ERP.Application.DTOs.PersonelEkGelirGiderDTOs;
using ERP.Data.DAO.PersonelEkGelirGider;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.PersonelEkGelirGiderConfig
{
    public class PersonelEkGelirGiderEntityToDTOMappingProfile : Profile
    {
        public PersonelEkGelirGiderEntityToDTOMappingProfile()
        {
            CreateMap<ekGelirGider, PersonelEkGelirGiderEkleDTO>();
            CreateMap<ekGelirGider, PersonelEkGelirGiderGuncelleDTO>();
            CreateMap<PersonelEkGelirGiderDAO, PersonelEkGelirGiderDTO>();

        }
    }
}