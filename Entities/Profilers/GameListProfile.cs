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
            CreateMap<Game, GameOutDTO>()
                .ForMember(
                    dest => dest.CategoryNames,
                    opt => opt.MapFrom(src => src.Categories.Select(c => c.Name).ToList())
                    )
                .ForMember(
                    dest => dest.PlatformNames,
                    opt => opt.MapFrom(src => src.Platforms.Select(c => c.Name).ToList())
                    );



        }
    }
}
