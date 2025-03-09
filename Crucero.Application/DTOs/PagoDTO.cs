using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero.Application.DTOs
{
    public record PagoDTO
    {
        public int Id { get; set; }
        public int ReservaId { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public int MetodoId { get; set; }
        public int TarjetaNumero { get; set; }
        public string? Estado { get; set; }  // Nullable si puede ser nulo
        public virtual ReservaDTO Reserva { get; set; } = null!;
        public virtual MetodoPagoDTO Metodo { get; set; } = null!;

    }
}
