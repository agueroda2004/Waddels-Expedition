using System;
using System.Collections.Generic;

namespace Crucero.Infraestructure.Models;

public partial class PrecioHabitaciones
{
    public int Id { get; set; }

    public int FechaCruceroId { get; set; }

    public int HabitacionId { get; set; }

    public decimal Precio { get; set; }

    public string? Estado { get; set; }

    public virtual FechasCrucero FechaCrucero { get; set; } = null!;

    public virtual Habitacion Habitacion { get; set; } = null!;
}
