using AutoMapper;
using ERP.Application.DTOs.PersonelKanun;
using ERP.Data.Entities;
using ERP.Domain.Commands.PersonelKanun;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Application.AutoMapper.PersonelKanun
{
    public class PersonelKanunDTOToEntityMappingProfile : Profile
    {
        public PersonelKanunDTOToEntityMappingProfile()
        {
            CreateMap<PersonelKanunDTO, istenAyrilmaNedenleri>();
            //CreateMap<PersonelKanunDTO, IstenAyrilmaNedenleriDAO>();
            CreateMap<PersonelKanunGuncelleDTO, personelKanun>();
            CreateMap<PersonelKanunEkleDTO, personelKanun>();
            CreateMap<PersonelKanunEkleDTO, PersonelKanunEKleCommand>()
                .ForMember(dest => dest.personelKanun, opt =>
                {
                    opt.MapFrom(src => src);
                });
            CreateMap<PersonelKanunGuncelleDTO, PersonelKanunGuncelleCommand>()
                .ForMember(dest => dest.personelKanun, opt =>
                {
                    opt.MapFrom(src => src);
                });
            
        }

    }
}

