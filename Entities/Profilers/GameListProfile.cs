using AutoMapper;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Profilers
{
    public class GameListProfile: Profile 
    {
        public GameListProfile()
        {
            CreateMap<Game, GameDisplayDTO>()
                .ForMember(
                    dest => dest.CategoryNames,
                    opt => opt.MapFrom(src => src.GameCategories.Select(gc => gc.Category.Name).ToList())
                    )
                .ForMember(
                    dest => dest.PlatformNames,
                    opt => opt.MapFrom(src => src.GamePlatforms.Select(c => c.Platform.Name).ToList())
                    )
                .ForMember(
                    dest => dest.DeveloperNames,
                    opt => opt.MapFrom(src => src.GameDevelopers.Select(d => d.Developer.Name).ToList())
                    )
                .ForMember(
                    dest => dest.LanguageDtos,
                    opt => opt.MapFrom(src => src.GameLanguageTypeLs.Select(d => d.LanguageTypeL.Language).ToList())
                    )
                ;




        }
    }
}
