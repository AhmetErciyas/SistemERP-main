using AutoMapper;
using ERP.Application.DTOs.IstenAyrılmaNedenleriDTOs;
using ERP.Data.DAO.IstenAyrilmaNedenleri;
using ERP.Data.Entities;
using ERP.Domain.Commands.IstenAyrilmaNedenleri;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.IstenAyrılmaNedenleriConfig
{
    public class IstenAyrilmaNedenleriDTOToEntityMappingProfile : Profile
    {
        public IstenAyrilmaNedenleriDTOToEntityMappingProfile()
        {
            CreateMap<IstenAyrilmaNedenleriDTO, istenAyrilmaNedenleri>();
            CreateMap<IstenAyrilmaNedenleriDTO, IstenAyrilmaNedenleriDAO > ();
            CreateMap<IstenAyrilmaNedenleriGuncelleDTO, istenAyrilmaNedenleri>();
            CreateMap<IstenAyrilmaNedenleriEkleDTO, istenAyrilmaNedenleri>();
            CreateMap<IstenAyrilmaNedenleriEkleDTO, IstenAyrilmaNedenleriEkleCommand>()
                .ForMember(dest => dest.IstenAyrilmaNedenleri, opt =>
                {
                    opt.MapFrom(src => src);
                });
            CreateMap<IstenAyrilmaNedenleriGuncelleDTO, IstenAyrilmaNedenleriGuncelleCommand>()
                .ForMember(dest => dest.IstenAyrilmaNedenleri, opt =>
                {
                    opt.MapFrom(src => src);
                });
            //CreateMap<KademeDTO, KademeAraQuery>()
            //   .ForMember(dest => dest.Kademe, opt =>
            //   {
            //       opt.MapFrom(src => src);
            //   });
        }
       
    }
}
