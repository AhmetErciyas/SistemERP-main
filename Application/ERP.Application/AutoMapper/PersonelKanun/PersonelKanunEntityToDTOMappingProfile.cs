using AutoMapper;
using ERP.Application.DTOs.PersonelKanun;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.PersonelKanun
{
    public class PersonelKanunEntityToDTOMappingProfile : Profile
    {
        public PersonelKanunEntityToDTOMappingProfile()
        {
            //CreateMap<IstenAyrilmaNedenleriDAO, IstenAyrilmaNedenleriDTO>();
            CreateMap<personelKanun, PersonelKanunDTO>();
        }
    }
}