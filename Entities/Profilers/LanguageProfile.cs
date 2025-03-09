using AutoMapper;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Profilers
{
    public class LanguageProfile: Profile
    {
        public LanguageProfile()
        {
            CreateMap<LanguageDisplayDto, Language>();
            CreateMap<Language, LanguageDisplayDto>().ForMember(
                dest => dest.GameLanguageTypes,
                opt => opt.MapFrom(src => src.GameLanguageTypeLs.Select(lt => lt.LanguageTypeL).Select(l => l.LanguageType.ToString()).Distinct().ToList()));
        }
    }
}
