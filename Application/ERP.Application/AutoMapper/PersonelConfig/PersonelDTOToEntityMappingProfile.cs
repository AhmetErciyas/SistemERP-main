using AutoMapper;
using ERP.Application.DTOs.KullaniciDTOs;
using ERP.Application.DTOs.OrganizasyonDTOs;
using ERP.Application.DTOs.PersonelDTOs;
using ERP.Data.DAO.Personel;
using ERP.Data.Entities;
using ERP.Domain.Commands;
using ERP.Domain.Commands.Kullanici;
using ERP.Domain.Commands.Organizasyon;
using ERP.Domain.Commands.Personel;

namespace ERP.Application.AutoMapper.PersonelConfig
{
    public class PersonelDTOToEntityMappingProfile : Profile
    {
        public PersonelDTOToEntityMappingProfile()
        {
            CreateMap<PersonelEkleDTO, personel>()
                .ForMember(dest => dest.personelAgi, opt =>
                {
                    opt.MapFrom(src => src.PersonelAgiEkleDto);
                })
                 .ForMember(dest => dest.personelBankaHesap, opt =>
                 {
                     opt.MapFrom(src => src.PersonelBankaHesapEkleDto);
                 })
                 .ForMember(dest => dest.personelDepartman, opt =>
                 {
                     opt.MapFrom(src => src.PersonelDepartmanEkleDTO);
                 })
                 .ForMember(dest => dest.personelEmeklilik, opt =>
                 {
                     opt.MapFrom(src => src.PersonelEmeklilikEkleDTO);
                 })
                 .ForMember(dest => dest.personelKimlik, opt =>
                 {
                     opt.MapFrom(src => src.PersonelKimlikBilgileriEkleDTO);
                 })
                 .ForMember(dest => dest.personelMaas, opt =>
                 {
                     opt.MapFrom(src => src.PersonelMaasEkleDTO);
                 })
                  .ForMember(dest => dest.personelTabiKanun, opt =>
                  {
                      opt.MapFrom(src => src.PersonelTabiKanunEkleDTO);
                  })
                   .ForMember(dest => dest.digerBilgiler, opt =>
                   {
                       opt.MapFrom(src => src.PersonelDiğerBilgileriEkleDTO);
                   })
                    .ForMember(dest => dest.ekGelirGider, opt =>
                   {
                       opt.MapFrom(src => src.PersonelEkGelirGiderEkleDTO);
                   });
            CreateMap<PersonelEkleDTO, PersonelEkleCommand>()
                .ForMember(dest => dest.Personel, opt =>
                {
                    opt.MapFrom(src => src);
                });

            CreateMap<PersonelGuncelleDTO, personel>()
                .ForMember(dest => dest.personelAgi, opt =>
                {
                    opt.MapFrom(src => src.PersonelAgiGuncelleDto);
                })
                 .ForMember(dest => dest.personelBankaHesap, opt =>
                 {
                     opt.MapFrom(src => src.PersonelBankaHesapGuncelleDto);
                 })
                 .ForMember(dest => dest.personelDepartman, opt =>
                 {
                     opt.MapFrom(src => src.PersonelDepartmanGuncelleDTO);
                 })
                 .ForMember(dest => dest.personelEmeklilik, opt =>
                 {
                     opt.MapFrom(src => src.personelEmeklilikGuncelleDTO);
                 })
                 .ForMember(dest => dest.personelKimlik, opt =>
                 {
                     opt.MapFrom(src => src.PersonelKimlikBilgileriGuncelleDTO);
                 })
                 .ForMember(dest => dest.personelMaas, opt =>
                 {
                     opt.MapFrom(src => src.PersonelMaasGuncelleDTO);
                 })
                  .ForMember(dest => dest.personelTabiKanun, opt =>
                  {
                      opt.MapFrom(src => src.PersonelTabiKanunGuncelleDTO);
                  })
                   .ForMember(dest => dest.digerBilgiler, opt =>
                   {
                       opt.MapFrom(src => src.PersonelDiğerBilgileriGuncelleDTO);
                   })
                    .ForMember(dest => dest.ekGelirGider, opt =>
                    {
                        opt.MapFrom(src => src.PersonelEkGelirGiderGuncelleDTO);
                    });

            CreateMap<PersonelAraDTO, PersonelAraDAO>();
            CreateMap<PersonelAraDTO, PersonelAraQuery>()
                .ForMember(dest => dest.Personel, opt =>
                {
                    opt.MapFrom(src => src);
                });

            CreateMap<PersonelGuncelleDTO, PersonelGuncelleCommand>()
                .ForMember(dest => dest.Personel, opt =>
                {
                    opt.MapFrom(src => src);
                });

            CreateMap<KisiDTO, Kisi>();
            CreateMap<KullaniciGirisDTO, KullaniciGirisCommand>();
            CreateMap<KullaniciDTO, KullaniciEkleCommand>();

            CreateMap<DepartmanDTO, DepartmanEkleCommand>()
                .ForMember(dest => dest.departman, opt =>
                {
                    opt.MapFrom(src => src);
                });

            CreateMap<DepartmanDTO, DepartmanGuncelleCommand>()
                .ForMember(dest => dest.Departman, opt =>
                {
                    opt.MapFrom(src => src);
                });

            CreateMap<DepartmanDTO, DepartmanAraQuery>()
                .ForMember(dest => dest.Departman, opt =>
                {
                    opt.MapFrom(src => src);
                });

            CreateMap<KademeDTO, KademeEkleCommand>()
                .ForMember(dest => dest.Kademe, opt =>
                {
                    opt.MapFrom(src => src);
                });

            CreateMap<KademeDTO, KademeGuncelleCommand>()
                .ForMember(dest => dest.Kademe, opt =>
                {
                    opt.MapFrom(src => src);
                });

            CreateMap<KademeDTO, KademeAraQuery>()
                .ForMember(dest => dest.Kademe, opt =>
                {
                    opt.MapFrom(src => src);
                });

            CreateMap<UnvanDTO, UnvanEkleCommand>()
                .ForMember(dest => dest.Unvan, opt =>
                {
                    opt.MapFrom(src => src);
                });

            CreateMap<UnvanDTO, UnvanGuncelleCommand>()
                .ForMember(dest => dest.Unvan, opt =>
                {
                    opt.MapFrom(src => src);
                });

            CreateMap<UnvanDTO, UnvanAraQuery>()
                .ForMember(dest => dest.Unvan, opt =>
                {
                    opt.MapFrom(src => src);
                });
        }
    }
}
