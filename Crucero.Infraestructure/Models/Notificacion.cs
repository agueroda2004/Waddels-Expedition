using System;
using System.Collections.Generic;

namespace Crucero.Infraestructure.Models;

public partial class Notificacion
{
    public int Id { get; set; }

    public int UsuarioId { get; set; }

    public string Mensaje { get; set; } = null!;

    public DateOnly FechaEnvio { get; set; }

    public string? Estado { get; set; }

    public virtual Usuario Usuario { get; set; } = null!;
}
