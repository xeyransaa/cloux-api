using AutoMapper;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Profilers
{
    public class BlogProfile: Profile
    {
        public BlogProfile()
        {
            CreateMap<Blog, BlogDisplayDto>()
                .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author.Name))
                .ForMember(dest => dest.AuthorPhoto, opt => opt.MapFrom(src => src.Author.PhotoUrl))
                .ForMember(dest => dest.BlogCategoryName, opt => opt.MapFrom(src => src.BlogCategory.Name));

            CreateMap<BlogInputDto, Blog>();
        }
    }
}
