using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero.Application.DTOs
{
    public record PrecioHabitacionesDTO
    {
        public int Id { get; set; }
        public int FechaCruceroId { get; set; }
        public int HabitacionId { get; set; }
        public decimal Precio { get; set; }
        public string? Estado { get; set; }  // Nullable si puede ser nulo
        public virtual FechasCruceroDTO FechasCrucero { get; set; } = null!;
        public virtual HabitacionDTO Habitacion { get; set; } = null!;
    }
}
