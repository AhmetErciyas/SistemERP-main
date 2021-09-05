using AutoMapper;
using ERP.Application.DTOs.Finans;
using ERP.Data.Entities;
using ERP.Domain.Commands.Finans;

namespace ERP.Application.AutoMapper.OrganizasyonConfig
{
    public class FinansDTOToEntityMappingProfile : Profile
    {
        public FinansDTOToEntityMappingProfile()
        {
            CreateMap<FinansFirmaEkleDTO, firma>();
            CreateMap<FinansFirmaEkleDTO, FinansFirmaEkleCommand>()
                .ForMember(dest => dest.Firma, opt =>
                {
                    opt.MapFrom(src => src);
                });
        }
    }
}
