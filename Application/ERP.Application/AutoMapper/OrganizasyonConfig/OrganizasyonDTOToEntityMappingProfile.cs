using AutoMapper;
using ERP.Application.DTOs.OrganizasyonDTOs;
using ERP.Data.DAO.Organizasyon;
using ERP.Data.Entities;
using ERP.Domain.Commands.Organizasyon;

namespace ERP.Application.AutoMapper.OrganizasyonConfig
{
    public class OrganizasyonDTOToEntityMappingProfile : Profile
    {
        public OrganizasyonDTOToEntityMappingProfile()
        {
            
            CreateMap<UnvanDTO, unvan>();
            CreateMap<UnvanDTO, UnvanDAO>();
            CreateMap<UnvanGuncelleDTO, unvan>();
            CreateMap<UnvanEkleDTO, unvan>();
            CreateMap<UnvanEkleDTO, UnvanEkleCommand>()
                .ForMember(dest => dest.Unvan, opt =>
                {
                    opt.MapFrom(src => src);
                });
            CreateMap<UnvanGuncelleDTO, UnvanGuncelleCommand>()
                .ForMember(dest => dest.Unvan, opt =>
                {
                    opt.MapFrom(src => src);
                });
            CreateMap<DepartmanDTO, KademeAraQuery>()
               .ForMember(dest => dest.Kademe, opt =>
               {
                   opt.MapFrom(src => src);
               });



            CreateMap<KademeDTO, kademe>();
            CreateMap<KademeDTO, KademeDAO>();
            CreateMap<KademeGuncelleDTO, kademe>();
            CreateMap<KademeEkleDTO, kademe>();
            CreateMap<KademeEkleDTO, KademeEkleCommand>()
                .ForMember(dest => dest.Kademe, opt =>
                {
                    opt.MapFrom(src => src);
                });
            CreateMap<KademeGuncelleDTO, KademeGuncelleCommand>()
                .ForMember(dest => dest.Kademe, opt =>
                {
                    opt.MapFrom(src => src);
                });
            CreateMap<KademeDTO, KademeAraQuery>()
               .ForMember(dest => dest.Kademe, opt =>
               {
                   opt.MapFrom(src => src);
               });



            CreateMap<DepartmanDTO, DepartmanDAO>();
            CreateMap<DepartmanDTO, departman>();
            CreateMap<DepartmanEkleDTO, departman>();
            CreateMap<DepartmanEkleDTO, DepartmanEkleCommand>()
                .ForMember(dest => dest.departman, opt =>
                {
                    opt.MapFrom(src => src);
                });
            CreateMap<DepartmanDTO, DepartmanGuncelleCommand>()
                .ForMember(dest => dest.Departman, opt =>
                {
                    opt.MapFrom(src => src);
                });
            CreateMap<DepartmanDTO, departman>();
            CreateMap<DepartmanDTO, DepartmanAraQuery>()
                .ForMember(dest => dest.Departman, opt =>
                {
                    opt.MapFrom(src => src);
                });
        }
    }
}
