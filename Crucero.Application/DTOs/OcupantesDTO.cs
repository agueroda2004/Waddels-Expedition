using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero.Application.DTOs
{
    public record OcupanteDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int ReservaId { get; set; }
        public string? Estado { get; set; } 
        public virtual ReservaDTO Reserva { get; set; } = null!;
    }
}
