using AutoMapper;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Profilers
{
    public class PlatformProfile: Profile
    {
        public PlatformProfile()
        {
            CreateMap<Platform, PlatformDisplayDto>()
                .ForMember(dest => dest.Games, opt => opt.MapFrom(src => src.GamePlatforms.Where(gp => !gp.Game.IsDeleted).Select(gp => gp.Game)));

            CreateMap<PlatformInputDto, Platform>();
        }
    }
}
