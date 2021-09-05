using AutoMapper;
using ERP.Application.DTOs;
using ERP.Data.DAO.Blog;
using ERP.Data.Entities;
using System.Linq;

namespace ERP.Application.AutoMapper.BlogConfig
{
    public class BlogEntityToDTOMappingProfile : Profile
    {
        public BlogEntityToDTOMappingProfile()
        {
            CreateMap<Post, PostDTO>()
                .ForMember(dest => dest.PostId, opt =>
                {
                    opt.MapFrom(src => src.Id);
                })
                .ForMember(dest => dest.AuthorName, opt =>
                {
                    opt.MapFrom(src => string.Format("{0} {1}", src.Author.Name, src.Author.Surname));
                })
                .ForMember(dest => dest.AuthorUsername, opt =>
                {
                    opt.MapFrom(src => src.Author.Username);
                });

            CreateMap<PostDAO, PostDTO>();
        }
    }
}
