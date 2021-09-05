using AutoMapper;
using ERP.Application.DTOs.IstenAyrılmaNedenleriDTOs;
using ERP.Data.DAO.IstenAyrilmaNedenleri;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.IstenAyrılmaNedenleriConfig
{
    public class IstenAyrilmaNedenleriEntityToDTOMappingProfile:Profile
    {
        public IstenAyrilmaNedenleriEntityToDTOMappingProfile()
        {
            CreateMap<IstenAyrilmaNedenleriDAO, IstenAyrilmaNedenleriDTO>();
            CreateMap<istenAyrilmaNedenleri, IstenAyrilmaNedenleriDTO>();
        }
    }
}
