using System;
using System.Collections.Generic;

namespace Crucero.Infraestructure.Models;

public partial class Ocupantes
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int ReservaId { get; set; }

    public string? Estado { get; set; }

    public virtual Reserva Reserva { get; set; } = null!;
}
