using AutoMapper;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Profilers
{
    public class GameListProfile: Profile 
    {
        public GameListProfile()
        {
            Dictionary<int, string> months = new Dictionary<int, string>()
        {
            { 1, "January" },
            { 2, "February" },
            { 3, "March" },
            { 4, "April" },
            { 5, "May" },
            { 6, "June" },
            { 7, "July" },
            { 8, "August" },
            { 9, "September" },
            { 10, "October" },
            { 11, "November" },
            { 12, "December" }
        };

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
                .ForMember(
                    dest => dest.ReleaseDay,
                    opt => opt.MapFrom(src => src.ReleaseDate.Day)
                    )
                .ForMember(
                    dest => dest.ReleaseYear,
                    opt => opt.MapFrom(src => src.ReleaseDate.Year)
                    )
                .ForMember(
                    dest => dest.ReleaseMonth,
                    opt => opt.MapFrom(src => months[src.ReleaseDate.Month])
                    )
               
                ;




        }
    }
}
