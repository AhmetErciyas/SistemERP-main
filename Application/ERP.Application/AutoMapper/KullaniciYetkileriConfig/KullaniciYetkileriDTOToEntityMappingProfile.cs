using AutoMapper;
using ERP.Application.DTOs.KullaniciYetkileriDTOs;
using ERP.Data.Entities;
using ERP.Domain.Commands.KullaniciYetkileri;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.KullaniciYetkileriConfig
{
    public class KullaniciYetkileriDTOToEntityMappingProfile : Profile
    {
        public KullaniciYetkileriDTOToEntityMappingProfile()
        {
            //CreateMap<KullaniciYetkiDTO, DepartmanDAO>();
            CreateMap<KullaniciYetkiDTO, kullaniciYetkileri>();
            CreateMap<KullaniciYetkiEkleDTO, kullaniciYetkileri>();
            CreateMap<KullaniciYetkiEkleDTO, KullaniciYetkileriEkleCommand>()
                .ForMember(dest => dest.kullaniciYetkileri, opt =>
                {
                    opt.MapFrom(src => src);
                });
            CreateMap<KullaniciYetkiGuncelleDTO, KullaniciYetkileriGuncelleCommand>()

                .ForMember(dest => dest.kullaniciYetkileri, opt =>
                {
                    opt.MapFrom(src => src);
                });
            CreateMap<KullaniciYetkiGuncelleDTO, kullaniciYetkileri>();
            //CreateMap<KullaniciYetkiDTO, DepartmanAraQuery>()
            //    .ForMember(dest => dest.Departman, opt =>
            //    {
            //        opt.MapFrom(src => src);
            //    });
        }
    }
}
