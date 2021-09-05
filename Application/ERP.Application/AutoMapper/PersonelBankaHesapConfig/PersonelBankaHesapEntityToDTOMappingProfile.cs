using AutoMapper;
using ERP.Application.DTOs.PersonelBankaHesapDTOs;
using ERP.Data.DAO.PersonelBankaHesap;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.PersonelBankaHesapConfig
{
    public class PersonelBankaHesapEntityToDTOMappingProfile : Profile
    {
        public PersonelBankaHesapEntityToDTOMappingProfile()
        {
            CreateMap<personelBankaHesap, PersonelBankaHesapEkleDto>();
            CreateMap<personelBankaHesap, PersonelBankaHesapGuncelleDto>();
            CreateMap<PersonelBankaHesapDAO, PersonelBankaHesapDto>();


        }
    }
}
