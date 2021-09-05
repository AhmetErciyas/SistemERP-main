using AutoMapper;
using ERP.Application.DTOs.PersonelTabiKanunDTOs;
using ERP.Data.DAO.PersonelTabiKanun;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.PersonelTabiKanunConfig
{
    public class PersonelTabiKanunEntityToDTOMappingProfile : Profile
    {
        public PersonelTabiKanunEntityToDTOMappingProfile()
        {
            CreateMap<personelTabiKanun, PersonelTabiKanunEkleDTO>();
            CreateMap<personelTabiKanun, PersonelTabiKanunGuncelleDTO>();
            CreateMap<PersonelTabiKanunDAO, PersonelTabiKanunDTO>();

        }
    }
}

