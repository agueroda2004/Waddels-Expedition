using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero.Application.DTOs
{
    public record ComplementoDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Precio { get; set; }
        public int AplicadoPorId { get; set; }
        public string? Estado { get; set; }  // Nullable si puede ser nulo
        public virtual AplicadoPorDTO Aplicado_por { get; set; } = null!;
        public virtual List<ReservaComplementoDTO> ReservaComplementos { get; set; } = null!;
    }
}
