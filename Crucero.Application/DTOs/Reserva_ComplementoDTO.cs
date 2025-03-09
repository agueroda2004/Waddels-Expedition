using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero.Application.DTOs
{
    public record ReservaComplementoDTO
    {
        public int Id { get; set; }
        public int ReservaId { get; set; }
        public int ComplementoId { get; set; }
        public int Cantidad { get; set; }
        public virtual ReservaDTO Reserva { get; set; } = null!;
        public virtual ComplementoDTO Complemento { get; set; } = null!;
    }
}
    