using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero.Application.DTOs
{
    public record NotificacionDTO
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Mensaje { get; set; } = null!;
        public DateTime FechaEnvio { get; set; }
        public string? Estado { get; set; }  // Nullable si puede ser nulo
        public virtual UsuarioDTO Usuario { get; set; } = null!;
    }
}
