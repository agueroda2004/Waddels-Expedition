using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucero.Application.DTOs
{
    public record UsuarioDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public DateTime FechaNacimiento { get; set; }
        public string Pais { get; set; } = null!;
        public int RolId { get; set; }
        public string? Estado { get; set; }  // Nullable si puede ser nulo
        public virtual List<ReservaDTO> Reservas { get; set; } = null!;
        public virtual RolDTO Rol { get; set; } = null!;
        public virtual List<NotificacionDTO> Notificacions { get; set; } = null!;

    }
}
