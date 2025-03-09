using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero.Application.DTOs
{
    public record RolDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Estado { get; set; }  // Nullable si puede ser nulo
        public virtual List<UsuarioDTO> Usuarios { get; set; } = null!;
    }
}
