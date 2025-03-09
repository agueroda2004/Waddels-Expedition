using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero.Application.DTOs
{
    public record FechasCruceroDTO
    {
        public int Id { get; set; }
        public int CruceroId { get; set; }
        [Display(Name = "Fecha de Inicio")]
        public DateOnly FechaInicio { get; set; }
        [Display(Name = "Fecha limite de pago")]
        public DateOnly FehcaLimitePago { get; set; }
        public string? Estado { get; set; }  // Nullable si puede ser nulo
        public virtual List<ReservaDTO> Reserva { get; set; } = null!;
        public virtual List<PrecioHabitacionesDTO> PrecioHabitaciones { get; set; } = null!;
        public virtual CruceroDTO Crucero { get; set; } = null!;
    }
}
