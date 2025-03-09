using AutoMapper;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Profilers
{
    public class CategoryProfile: Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDisplayDto>()
                .ForMember(dest => dest.Games, opt => opt.MapFrom(src => src.GameCategories.Select(gp => gp.Game).ToList()));

            CreateMap<CategoryInputDto, Category>();
        }
    }
}
