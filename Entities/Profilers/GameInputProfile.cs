using AutoMapper;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Profilers
{
    public class GameInputProfile : Profile
    {
        public GameInputProfile() {
            CreateMap<GameInputDTO, Game>();
             
        }
    }
}
