using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero.Application.DTOs
{
    public record ReservaDTO
    {
        [Display(Name = "Reserva")]
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int FechaCruceroId { get; set; }
        [Display(Name = "Cantidad Habitaciones")]
        public int CantidadHabitaciones { get; set; }
        [Display(Name = "Cantidad huéspedes")]
        public int CantidadPasajeros { get; set; }
        public decimal Total { get; set; }
        public decimal Pagado { get; set; }
        [Display(Name = "Estado")]
        public int EstadoId { get; set; }
        public virtual UsuarioDTO Usuario { get; set; } = null!;
        public virtual List<PagoDTO> Pagos { get; set; } = null!;
        public virtual EstadoReservaDTO Estado { get; set; } = null!;
        public virtual List<OcupanteDTO> Ocupantes { get; set; } = null!;
        public virtual List<ReservaComplementoDTO> ReservaComplemento { get; set; } = null!;
        public virtual List<ReservaDetalleDTO> ReservaDetalle { get; set; } = null!;
        public virtual FechasCruceroDTO FechasCrucero { get; set; } = null!;
    }
}
