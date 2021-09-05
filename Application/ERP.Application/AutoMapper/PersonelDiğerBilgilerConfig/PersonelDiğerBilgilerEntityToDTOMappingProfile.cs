using AutoMapper;
using ERP.Application.DTOs.PersonelDiğerBilgileriDTOS;
using ERP.Data.DAO.PersonelDiğerBilgileri;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.PersonelDiğerBilgilerConfig
{
    public class PersonelDiğerBilgilerEntityToDTOMappingProfile : Profile
    {
        public PersonelDiğerBilgilerEntityToDTOMappingProfile()
        {
            CreateMap<digerBilgiler, PersonelDiğerBilgileriEkleDTO>();
            CreateMap<digerBilgiler, PersonelDiğerBilgileriGuncelleDTO>();
            CreateMap<PersonelDiğerBilgileriDAO, PersonelDiğerBilgileriDTO>();

        }
    }
}
