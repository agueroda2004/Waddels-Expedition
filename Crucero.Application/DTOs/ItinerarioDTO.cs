using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero.Application.DTOs
{
    public record ItinerarioDTO
    {
        public int Id { get; set; }
        public int CruceroId { get; set; }
        public int PuertoId { get; set; }
        public string Dia { get; set; } = null!;
        public string? Descripcion { get; set; }  // Nullable si puede ser nulo
        public virtual CruceroDTO Crucero { get; set; } = null!;
        public virtual PuertoDTO Puerto { get; set; } = null!;
    }
}
