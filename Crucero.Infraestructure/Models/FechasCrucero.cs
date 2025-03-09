using System;
using System.Collections.Generic;

namespace Crucero.Infraestructure.Models;

public partial class FechasCrucero
{
    public int Id { get; set; }

    public int CruceroId { get; set; }

    public DateOnly FechaInicio { get; set; }

    public DateOnly FehcaLimitePago { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<Reserva> Reserva { get; set; } = null!;
    public virtual ICollection<PrecioHabitaciones> PrecioHabitaciones { get; set; } = null!;
    public virtual Crucero Crucero { get; set; } = null!;
}
