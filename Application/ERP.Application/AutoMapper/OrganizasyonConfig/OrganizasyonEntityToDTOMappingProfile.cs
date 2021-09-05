using AutoMapper;
using ERP.Application.DTOs.OrganizasyonDTOs;
using ERP.Data.DAO.Organizasyon;
using ERP.Data.Entities;

namespace ERP.Application.AutoMapper.OrganizasyonConfig
{
    public class OrganizasyonEntityToDTOMappingProfile : Profile
    {
        public OrganizasyonEntityToDTOMappingProfile()
        {
            CreateMap<departman, DepartmanDTO>();
            CreateMap<unvan, UnvanDTO>();
            CreateMap<DepartmanDAO, DepartmanDTO>();
            CreateMap<UnvanDAO, UnvanDTO>();
            CreateMap<KademeDAO, KademeDTO>();
            CreateMap<kademe, KademeDTO>();

        }
    }
}
