using AutoMapper;
using ERP.Application.DTOs.IzinGrupDTOs;
using ERP.Data.DAO.IzinGrup;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.IzinGrupConfig
{
    public class IzinGrupEntityToDTOMappingProfile:Profile
    {
        public IzinGrupEntityToDTOMappingProfile()
        {
            CreateMap<IzinGrupDAO, IzinGrupDTO>();
            CreateMap<izinGrubu, IzinGrupDTO>();
        }
    }
}
