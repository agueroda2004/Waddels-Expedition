using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero.Application.DTOs
{
    public record ReservaDetalleDTO
    {
        public int Id { get; set; }
        public int ReservaId { get; set; }
        public int HabitacionId { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string? Estado { get; set; }  // Nullable si puede ser nulo
        public virtual ReservaDTO Reserva { get; set; } = null!;
        public virtual HabitacionDTO Habitacion { get; set; } = null!;

    }
}
