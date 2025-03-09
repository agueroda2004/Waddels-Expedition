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
    public class Reserva_complementoProfile : Profile
    {
        public Reserva_complementoProfile()
        {
            CreateMap<ReservaComplementoDTO, ReservaComplemento>().ReverseMap();
        }
    }
}
