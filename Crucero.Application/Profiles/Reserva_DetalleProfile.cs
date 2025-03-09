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
    public class Reserva_DetalleProfile : Profile
    {
        public Reserva_DetalleProfile()
        {
            CreateMap<ReservaDetalleDTO, ReservaDetalle>().ReverseMap();
        }
    }
}
