using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero.Application.DTOs
{
    public record PuertoDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Pais { get; set; } = null!;
        public int DestinoId { get; set; }
        public string? Estado { get; set; }  // Nullable si puede ser nulo
        public virtual List<ItinerarioDTO> Itinerarios { get; set; } = null!;
        public virtual DestinoDTO Destino { get; set; } = null!;
    }
}
