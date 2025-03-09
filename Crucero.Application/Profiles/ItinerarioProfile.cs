using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Crucero.Application.DTOs;
using Crucero.Infraestructure.Models;

namespace Crucero.Application.Profiles
{
    public class ItinerarioProfile : Profile
    {
        public ItinerarioProfile()
        {
            CreateMap<ItinerarioDTO, Itinerario>().ReverseMap();
        }
    }
}
