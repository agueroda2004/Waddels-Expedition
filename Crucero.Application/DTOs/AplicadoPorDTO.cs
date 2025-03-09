using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero.Application.DTOs
{
    public record AplicadoPorDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Estado { get; set; }
        public virtual List<ComplementoDTO> Complementos { get; set; } = null!;
    }
}
