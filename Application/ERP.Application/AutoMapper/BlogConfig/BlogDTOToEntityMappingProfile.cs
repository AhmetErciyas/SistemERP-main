using AutoMapper;
using ERP.Application.DTOs;
using ERP.Data.DAO.Blog;
using ERP.Data.Entities;
using ERP.Domain.Commands;

namespace ERP.Application.AutoMapper.BlogConfig
{
    public class BlogDTOToEntityMappingProfile : Profile
    {
        public BlogDTOToEntityMappingProfile()
        {
            CreateMap<PostDTO, Post>();
            CreateMap<PostDTO, PostDAO>();
            CreateMap<PostDTO, PostEkleCommand>()
                .ForMember(dest => dest.Post, opt =>
                {
                    opt.MapFrom(src => src);
                });

            CreateMap<PostAraDTO, PostAraDAO>();
            CreateMap<PostAraDTO, PostAraQuery>()
                .ForMember(dest => dest.PostAraDAO, opt =>
                {
                    opt.MapFrom(src => src);
                });
        }
    }
}
