using AutoMapper;
using ERP.Application.DTOs.PersonelKimlikBilgileriDTOs;
using ERP.Data.DAO.PersonelKimlikBilgileri;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.PersonelKimlikConfig
{
    public class PersonelKimlikEntityToDTOMappingProfile : Profile
    {
        public PersonelKimlikEntityToDTOMappingProfile()
        {
            CreateMap<personelKimlik, PersonelKimlikBilgileriEkleDTO>();
            CreateMap<personelKimlik, PersonelKimlikBilgileriGuncelleDTO>();
            CreateMap<PersonelKimlikBilgileriDAO, PersonelKimlikBilgileriDTO>();

        }
    }
}