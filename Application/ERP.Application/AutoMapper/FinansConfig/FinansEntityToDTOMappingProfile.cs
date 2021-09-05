using AutoMapper;
using ERP.Application.DTOs.Finans;
using ERP.Application.DTOs.OrganizasyonDTOs;
using ERP.Data.DAO.Organizasyon;
using ERP.Data.Entities;

namespace ERP.Application.AutoMapper.OrganizasyonConfig
{
    public class FinansEntityToDTOMappingProfile : Profile
    {
        public FinansEntityToDTOMappingProfile()
        {
            CreateMap<firma, FinansFirmaDTO>();
            CreateMap<firmaTur, FirmaTurDTO>();
        }
    }
}
