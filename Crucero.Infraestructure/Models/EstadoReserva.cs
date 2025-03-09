using System;
using System.Collections.Generic;

namespace Crucero.Infraestructure.Models;

public partial class EstadoReserva
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Estado { get; set; }

    public virtual ICollection<Reserva> Reserva { get; set; } = new List<Reserva>();
}
