using AutoMapper;
using ERP.Application.DTOs.KullaniciYetkileriDTOs;
using ERP.Data.DAO.KullaniciYetkileri;
using ERP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.KullaniciYetkileriConfig
{
    public class KullaniciYetkileriEntityToDTOMappingProfile : Profile
    {
        public KullaniciYetkileriEntityToDTOMappingProfile()
        {
            CreateMap<kullaniciYetkileri, KullaniciYetkiDTO>();
            //CreateMap<kullaniciYetkileri, KullaniciYetkiGuncelleDTO>();

            CreateMap<KullaniciYetkiDAO, KullaniciYetkiDTO>();


        }
    }
}

