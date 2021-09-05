using AutoMapper;
using ERP.Application.DTOs.PersonelAgiDTOs;
using ERP.Application.DTOs.PersonelBankaHesapDTOs;
using ERP.Application.DTOs.PersonelDepartmanDTOs;
using ERP.Application.DTOs.PersonelDiğerBilgileriDTOS;
using ERP.Application.DTOs.PersonelDTOs;
using ERP.Application.DTOs.PersonelEkGelirGiderDTOs;
using ERP.Application.DTOs.PersonelEmeklilikDTOs;
using ERP.Application.DTOs.PersonelKimlikBilgileriDTOs;
using ERP.Application.DTOs.PersonelMaasDTOs;
using ERP.Application.DTOs.PersonelTabiKanunDTOs;
using ERP.Data.DAO.Personel;
using ERP.Data.Entities;

namespace ERP.Application.AutoMapper.PersonelConfig
{
    public class PersonelEntityToDTOMappingProfile : Profile
    {
        public PersonelEntityToDTOMappingProfile()
        {
            CreateMap<personelAgi, PersonelAgiDto>();
            CreateMap<personelBankaHesap, PersonelBankaHesapDto>();
            CreateMap<personelDepartman, PersonelDepartmanDTO>();
            CreateMap<digerBilgiler, PersonelDiğerBilgileriDTO>();
            CreateMap<digerBilgiler, PersonelDiğerBilgileriDTO>();
            CreateMap<personelEmeklilik, PersonelEmeklilikDTO>();
            CreateMap<personelKimlik, PersonelKimlikBilgileriDTO>();
            CreateMap<personelMaas, PersonelMaasDTO>();
            CreateMap<personelTabiKanun, PersonelTabiKanunDTO>();
            CreateMap<ekGelirGider, PersonelEkGelirGiderDTO>();
            CreateMap<personel, PersonelDTO>()
                .ForMember(dest => dest.personelAgiDto, opt =>
                {
                    opt.MapFrom(src => src.personelAgi);
                })
                .ForMember(dest => dest.personelBankaHesapDto, opt =>
                {
                    opt.MapFrom(src => src.personelBankaHesap);
                })
                .ForMember(dest => dest.personelDepartmanDTO, opt =>
                {
                    opt.MapFrom(src => src.personelDepartman);
                })
                .ForMember(dest => dest.personelDiğerBilgileriDTO, opt =>
                {
                    opt.MapFrom(src => src.digerBilgiler);
                }).ForMember(dest => dest.personelEmeklilikDTO, opt =>
                {
                    opt.MapFrom(src => src.personelEmeklilik);
                })
                .ForMember(dest => dest.personelKimlikBilgileriDTO, opt =>
                {
                    opt.MapFrom(src => src.personelKimlik);
                }).ForMember(dest => dest.personelMaasDTO, opt =>
                {
                    opt.MapFrom(src => src.personelMaas);
                })
                .ForMember(dest => dest.personelTabiKanunDTO, opt =>
                {
                    opt.MapFrom(src => src.personelTabiKanun);
                }).ForMember(dest => dest.PersonelEkGelirGiderDTO, opt =>
                {
                    opt.MapFrom(src => src.ekGelirGider);
                });
               

            CreateMap<PersonelDAO, PersonelDTO>()
                .ForMember(dest => dest.personelAgiDto, opt =>
                {
                    opt.MapFrom(src => src.personelAgiDto);
                })
                .ForMember(dest => dest.personelBankaHesapDto, opt =>
                {
                    opt.MapFrom(src => src.personelBankaHesapDto);
                })
                .ForMember(dest => dest.personelDepartmanDTO, opt =>
                {
                    opt.MapFrom(src => src.personelDepartmanDTO);
                })
                .ForMember(dest => dest.personelDiğerBilgileriDTO, opt =>
                {
                    opt.MapFrom(src => src.personelDiğerBilgileriDTO);
                }).ForMember(dest => dest.personelEmeklilikDTO, opt =>
                {
                    opt.MapFrom(src => src.personelEmeklilikDTO);
                })
                .ForMember(dest => dest.personelKimlikBilgileriDTO, opt =>
                {
                    opt.MapFrom(src => src.personelKimlikBilgileriDTO);
                }).ForMember(dest => dest.personelMaasDTO, opt =>
                {
                    opt.MapFrom(src => src.personelMaasDTO);
                })
                .ForMember(dest => dest.personelTabiKanunDTO, opt =>
                {
                    opt.MapFrom(src => src.personelTabiKanunDTO);
                }).ForMember(dest => dest.PersonelEkGelirGiderDTO, opt =>
                {
                    opt.MapFrom(src => src.PersonelEkGelirGiderDTO);
                });
            CreateMap<PersonelAraDAO, PersonelAraDTO>();

        }
    }
}
