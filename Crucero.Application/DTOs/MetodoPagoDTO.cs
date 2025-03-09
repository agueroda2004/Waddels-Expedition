using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero.Application.DTOs
{
    public record MetodoPagoDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Estado { get; set; }  // Nullable si puede ser nulo
        public virtual List<MetodoPagoDTO> MetodoPagos { get; set; } = null!;
    }
}
